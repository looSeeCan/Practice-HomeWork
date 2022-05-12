using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectableManager : MonoBehaviour
{
    //We are going to want to make this a singleton. in order to do that we are going to declare:
    public static CollectableManager Instance;//calling it Instance

    public int totalCubesCollected;//to be assigned in the inspector
    public int collectedCount;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(this);
        }
    }

    public void AddOneToCount()//everytime this method is called 
    {
        collectedCount++;//add one to collectedCount
        Debug.Log($"Adding one to count. You are now at: {collectedCount}");
        if (collectedCount == totalCubesCollected)//compare to see if all the cubes were collected
        {
            Debug.Log("You collected all the cubes! You win.");
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        collectedCount = 0;//start with collectedCount = 0
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
