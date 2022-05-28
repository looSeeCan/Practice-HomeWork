using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class OculusHandModelR : MonoBehaviour//attached to the right hand prefab
{
    [SerializeField] InputActionReference triggerAction;//Declare two input action reference variables
    [SerializeField] InputActionReference gripAction;
    Animator anim;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        triggerAction.action.started += OnTriggerPressed;
        triggerAction.action.canceled += OnTriggerUnPressed;
        gripAction.action.started += OnGripPressed;
        gripAction.action.canceled += OnGripUnPressed;    
    }

    void OnTriggerPressed(InputAction.CallbackContext context)//this needs to be able to receive the type InputAction.CallbackContext, wheather or not you need that info
    {
        anim.SetBool("TriggerPressed", true);
        Debug.Log("Trigger Pressed");
    }
    void OnTriggerUnPressed(InputAction.CallbackContext context)
    {   
        anim.SetBool("TriggerPressed", false);
        Debug.Log("Trigger UnPressed");
    }
    void OnGripPressed(InputAction.CallbackContext context)
    {
        anim.SetBool("GripPressed", true);
        Debug.Log("Grip Pressed");
    }
    void OnGripUnPressed(InputAction.CallbackContext context)
    {   
        anim.SetBool("GripPressed", false);
        Debug.Log("Grip Unpressed");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
