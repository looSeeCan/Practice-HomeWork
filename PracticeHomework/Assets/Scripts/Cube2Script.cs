using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube2Script : MonoBehaviour
{
    public EventManager evMan;
    
    // Start is called before the first frame update
    void Start()
    {
        evMan.SpacebarPress += MoveRight;
    }

    private void onDestroy()
    {
        evMan.SpacebarPress -= MoveRight;
    }

    void MoveRight(float recievedFloat)
    {
        Debug.Log("Cube 2 is moving right!");
        transform.position += new Vector3(recievedFloat, 0f, 0f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
