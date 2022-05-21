using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class EventManager : MonoBehaviour//this script is attached to the EventManager Game object
{
        //create a unity event to call
        // public event System.Action SpacebarPress;//this was declared first without <float>
        public event System.Action<float> SpacebarPress;
        public float sentFloatValue;
    public void ButtonPress(InputAction.CallbackContext context)
    {
        // Debug.Log("Recieved button press input with context of: " + context.phase);//when spacebar is pressed, two events fire: started and performed, when you release the button, a third event fires with the context of "canceled
        if(context.performed)//returns true if the current phase is the performed phse. We want the event to only fire once. IDK it fires twice. Ask about this
        {   
            SpacebarPress?.Invoke(sentFloatValue);//checks tro see if there are any methods subcrided to the SpaceBArPress event before trying to fire it to avoid getting a null reference exception error.
            //im pretty sure this is just like the ternary in JavaScript
            Debug.Log($"sentFloatValue: {sentFloatValue}");
            Debug.Log("Invoked spacebarPress event!");
            Debug.Log($"Recieved button press input with context of: {context.phase}");
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
