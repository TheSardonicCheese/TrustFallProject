using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AI : MonoBehaviour
{
    public DifSel difSelector;
    
    public int Lives = 10;
    void Awake()
    {
        
    }
    void Start()
    {
        //gets player stats
        difSelector = gameObject.GetComponent<DifSel>();
    }

    // Update is called once per frame
    void Update()
    {
        //displays the current health of AI.
        //gets player's choice of difficulty from previous round.
        //gives players previous round difficulty chosen for ai as player's current round difficulty.
        //updates AI health based on the difficulty given by the player.
    }

   
    
}
