using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager Instance;//1 make this a singleton
    public int currentScore;//2
    
    private void Awake()
    {
        if(Instance == null)
        {
            Instance = this;
        }
        else 
        {
            Destroy(this);
        }
    }

    public void AddToScore()
    {
        currentScore ++;
        Debug.Log("Current score is now: " + currentScore);
    }

    // Start is called before the first frame update
    void Start()
    {
        currentScore = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
