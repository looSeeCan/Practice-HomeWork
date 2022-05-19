using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PairProgramming04_RLG : MonoBehaviour//this is attached to the Player component
{
    public float speed;//speed shows up under the script on the inspector
    
    Vector3 movement;
    public bool canMove;
    public bool wonGame;//tell the script when to stop
    public float minRedTime, maxRedTime, minGreenTime, maxGreenTime;//how long the lights stay active
    public Transform respawnTransform;//implement the feature of respawning. This will be an empty GameObject placed in the position that you will be telported back to.
    public MeshRenderer stoplightRend;//update the color of the quads material in the coroutine StoplightTimer
    public Color redColor, greenColor;
    bool inLeniencyTime;//give the player a bit more leniency when the light turns red. This bool will turn on briefly after the red light
    //turns on , and while it's true we won't send the player back to the respawn point
    public float leniencyFloat;
    public void OnMovement(InputAction.CallbackContext context)
    {
        // Debug.Log($"context: {context}");
        Vector2 givenMovement = context.ReadValue<Vector2>();
        // Debug.Log(givenMovement);
        // Debug.Log($"movement: {movement}");
        movement = new Vector3(givenMovement.x, 0f, givenMovement.y);
        // Debug.Log($"movementA: {movement}");

        // Debug.Log($"givenMovement: {givenMovement.x}");
    }
    // Start is called before the first frame update
    void Start()
    {
        canMove = true;//make sure to set canMove to true
        wonGame = false;//wonGame to false
        StartCoroutine(StoplightTimer());//start the StopLight timer coroutine
    }

    IEnumerator StoplightTimer()//Create a new coroutine
    {
        while(!wonGame)//this while loop will play until the bool wonGame is set to true
        {
            if(!canMove)//if canMove is false -meaning this conditition is true- Red light should be activated. Cant move 
            {
                stoplightRend.sharedMaterial.color = redColor;
                yield return new WaitForSeconds(Random.Range(minRedTime, maxRedTime));
                canMove = true;
            }
            else//if canMove is true -meaning the condition is false- the green light should be activated
            {
                stoplightRend.sharedMaterial.color = greenColor;
                yield return new WaitForSeconds(Random.Range(minGreenTime, maxGreenTime));
                canMove = false;
                StartCoroutine(LeiniencyTimer());
            }
        }
    }

    IEnumerator LeiniencyTimer()//create a new Coroutine
    {
        inLeniencyTime = true;
        yield return new WaitForSeconds(leniencyFloat);
        inLeniencyTime = false;
    }
    // Update is called once per frame
    void Update()
    {
        //implement the feature of respawning if you try to move when you aren't allowed to
        if(!canMove)//if canMove is false
        {
            if(movement.magnitude > 0f && !inLeniencyTime)//if there is a movement > 0f
            {
                transform.position = respawnTransform.position;//you go back to this position
            }
        }
        else// if canMove is true then you just move regularily.
        {
        transform.position += movement * speed * Time.deltaTime;//update the position by the movement vector
        }
    }
}
