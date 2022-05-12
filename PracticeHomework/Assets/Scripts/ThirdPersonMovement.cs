using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class ThirdPersonMovement : MonoBehaviour
{
    public float speed = 1f;//this is going to define how fast we actully move
    Vector3 movementVector;//constantly update our postion by the movement vector

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = transform.position + movementVector * Time.deltaTime * speed;//how we update our movement
    }

    public void onMovement(InputAction.CallbackContext context)
    {
        Vector2 movementVector2 = context.ReadValue<Vector2>();
        movementVector = new Vector3(movementVector2.x, 0, movementVector2.y);
    }
}
