using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndTriggerBox : MonoBehaviour
{
    public  PairProgramming04_RLG rlgl;//this variable is a reference to the Pairprogramming04_RLG script(component).
    public void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Player"))
        {
            Debug.Log("You Win!");
            rlgl.wonGame = true;
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
