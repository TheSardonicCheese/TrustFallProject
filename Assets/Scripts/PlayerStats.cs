using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerStats : MonoBehaviour
{
    public int lives = 5;
    // Start is called before the first frame update
    public enum difficulty
    {
        hard,
        easy
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (lives <= 0)
        {
            PlayerPrefs.SetInt("previousChoice", 0);
            PlayerPrefs.SetInt("livesAi", 10);
            SceneManager.LoadScene("MainMenu");
        }

    }

}
