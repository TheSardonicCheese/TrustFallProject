using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class DifSel : MonoBehaviour
{
    //create list for hard levels.
    public List<GameObject> Hard = new List<GameObject>(GameObject.FindGameObjectsWithTag("Hard"));
    //create list for easy levels.
    public List<GameObject> Easy = new List<GameObject>(GameObject.FindGameObjectsWithTag("Easy"));

    // Start is called before the first frame update
    public enum Difficulty
    {
        Hard,
        Easy
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
