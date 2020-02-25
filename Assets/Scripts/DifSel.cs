using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class DifSel : MonoBehaviour
{
    //create list for hard levels.
    //public List<GameObject> Hard = new List<GameObject>(GameObject.FindGameObjectsWithTag("Hard"));
    //create list for easy levels.
    //public List<GameObject> Easy = new List<GameObject>(GameObject.FindGameObjectsWithTag("Easy"));

    // Start is called before the first frame update

    public AI Ai;
    public  string playerSelection = "Easy";
    public int previousChoice = 0;
    public int difficulty;

    public Sprite[] Exp;
    public Text[] LivesDisp;
    public Image[] Images;
    public int livesAi = 10;
    List<int> easyLevels = new List<int>() { 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 };
    List<int> hardLevels = new List<int>() { 13, 14, 15, 16, 17, 18, 19, 20, 21, 22 };
    public int levelNum;


    /*void Awake()
    {

        DontDestroyOnLoad(this);
        
            
        }
    }*/
    private void Start()
    {
        //load player prefs level selection
        //set Ai's choice = player pref
        
        
        difficulty = PlayerPrefs.GetInt("previousChoice");


        livesAi = PlayerPrefs.GetInt("livesAi");
        if (difficulty == 0)
        {
            livesAi -= Random.Range(0, 2);
        }
        else
        {
            livesAi -= Random.Range(2, 4);
        }

        if (livesAi <= 10 && livesAi > 7)
        {
            LivesDisp[0].text = livesAi.ToString();
            Images[0].sprite = Exp[0];

        }
        else if (livesAi <= 7 && livesAi > 5)
        {
            LivesDisp[0].text = livesAi.ToString();
            Images[0].sprite = Exp[1];

        }
        else if (livesAi <= 5 && livesAi >= 2)
        {
            LivesDisp[0].text = livesAi.ToString();
            Images[0].sprite = Exp[2];
        }
        else if (livesAi <= 1)
        {
            LivesDisp[0].text = livesAi.ToString();
            Images[0].sprite = Exp[4];
        }
        Debug.Log("livesAi = " + livesAi);
    }
    void Update()
    {
        if (Input.GetKeyDown("r"))
        {
            PlayerPrefs.DeleteAll();
            livesAi = 10;
            Debug.Log("livesAi = " + livesAi);
            difficulty = 0;
            Debug.Log("difficulty = " + difficulty);

        }

    }
    public void Easyselection()
    {
        //save choice for next time
        PlayerPrefs.SetInt("previousChoice", 0);
        playerSelection = "Easy";
        //load level
        PlayerPrefs.SetInt("livesAi", livesAi);
        if (difficulty == 0)
        {
            levelNum = Random.Range(easyLevels[0],easyLevels.Count);
            Debug.Log(levelNum);
            easyLevels.Remove(levelNum);
            SceneManager.LoadScene(levelNum);
        }
        else
        {
            levelNum = Random.Range(hardLevels[0], hardLevels.Count);
            Debug.Log(levelNum);
            hardLevels.Remove(levelNum);
            SceneManager.LoadScene(levelNum);
        }

    }
    public void Hardselection()
    {
        PlayerPrefs.SetInt("previousChoice", 1);
        playerSelection = "Hard";
        //load level
        PlayerPrefs.SetInt("livesAi", livesAi);
        if (difficulty == 0)
        {
            levelNum = Random.Range(easyLevels[0], easyLevels.Count);
            easyLevels.Remove(levelNum);
            SceneManager.LoadScene(levelNum);
        }
        else
        {
            levelNum = Random.Range(hardLevels[0], hardLevels.Count);
            hardLevels.Remove(levelNum);
            SceneManager.LoadScene(levelNum);
        }
        
    }
    
}
