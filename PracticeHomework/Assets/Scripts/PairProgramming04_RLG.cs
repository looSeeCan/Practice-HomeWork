using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PairProgramming04_RLG : MonoBehaviour//this is attached to the Player component
{
    public float speed;//speed shows up under the script on the inspector
    
    Vector3 movement;
    public bool canMove;

    public void OnMovement(InputAction.CallbackContext context)
    {
        // Debug.Log($"context: {context}");
        Vector2 givenMovement = context.ReadValue<Vector2>();
        Debug.Log(givenMovement);
        movement = new Vector3(givenMovement.x, 0f, givenMovement.y);
        // Debug.Log($"movement: {movement}");
        // Debug.Log($"givenMovement: {givenMovement.x}");
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += movement * speed * Time.deltaTime;//update the position by the movement vector
    }
}
