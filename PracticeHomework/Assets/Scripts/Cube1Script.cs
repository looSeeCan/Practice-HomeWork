using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube1Script : MonoBehaviour//attached to the cube object
{
    public EventManager evMan;//in this script you will want a reference to the EventManager Script
    
    // Start is called before the first frame update
    void Start()
    {
        evMan.SpacebarPress += MoveUp;
    }

    public void onDestroy()
    {
        evMan.SpacebarPress -= MoveUp;//in the event of the destruction of the GameObject by creating a new OnDestroy() method and typing the same line but with -=
    }

    void MoveUp(float receivedFloat)
    {
        Debug.Log($"recievedFloat: {receivedFloat}");
        Debug.Log("Cube 1 is moving up!");
        // transform.position += Vector3.up;
        transform.position += new Vector3(0f, receivedFloat, 0f);//using a a float value to move the cube
    }
    
    // Update is called once per frame
    void Update()
    {
        
    }
}
