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

    public Sprite[] Exp;
    public Text[] LivesDisp;
    public Image[] Images;
    public int livesAi = 10;

    void Awake()
    {

        DontDestroyOnLoad(this);
        if (livesAi <= 10 && livesAi > 7)
        {
            LivesDisp[0].text = livesAi.ToString();
            Images[0].sprite = Exp[0];
            
        }
        else if(livesAi <=6 && livesAi > 5)
        {
            LivesDisp[0].text = livesAi.ToString();
            Images[0].sprite = Exp[1];
            
        }
        else if(livesAi <=4 && livesAi >= 2)
        {
            LivesDisp[0].text = livesAi.ToString();
            Images[0].sprite = Exp[2];  
        }
        else if(livesAi <= 1 )
        {
            LivesDisp[0].text = livesAi.ToString();
            Images[0].sprite = Exp[4];
            
        }
    }

    public void Easyselection()
    {
        SceneManager.LoadScene("RLevel 1");
        playerSelection = "Easy";
    }
    public void Hardselection()
    {
        SceneManager.LoadScene("RLevel 8");
        playerSelection = "Hard";
    }
}
