﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class EndLevel : MonoBehaviour
{
    public int levelsCompleted;
    public int livesAi;
    
    
    // Start is called before the first frame update
    void OnTriggerEnter2D(Collider2D col)
    {
        if(col.gameObject.tag == "Player" && levelsCompleted < 10)
        {
            levelsCompleted++;
            PlayerPrefs.SetInt("finishedLevels", levelsCompleted);
            SceneManager.LoadScene("Difficulty Selector");
        }
        
        if (col.gameObject.tag == "Player" && levelsCompleted >= 10)
        {
            PlayerPrefs.SetInt("previousChoice", 0);
            PlayerPrefs.SetInt("livesAi", 10);
            PlayerPrefs.SetInt("finishedLevels", 0);
            SceneManager.LoadScene("PlayerWins");
        }
        if( livesAi <= 0)
        {
            SceneManager.LoadScene("AiDied");
        }

    }
    void Start()
    {
        levelsCompleted = PlayerPrefs.GetInt("finishedLevels");
        livesAi = PlayerPrefs.GetInt("livesAi");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
