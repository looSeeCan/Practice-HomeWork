using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveObject : MonoBehaviour
{
    public float speed = 1f; //declare the variable as a public variavle of float type. speed is the name of the variable.
        //the f statnds for float. Sets a default speed value for the object to move

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = transform.position + transform.forward * Time.deltaTime * speed;
    }
}
