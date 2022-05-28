using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class OculusHandModelL : MonoBehaviour//attached to lhand prefab
{
    [SerializeField] InputActionReference triggerAction;
    [SerializeField] InputActionReference gripAction;
    Animator anim;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        // Debug.Log(anim);
        triggerAction.action.started += OnTriggerPressed;
        triggerAction.action.canceled += OnTriggerUnpressed;
        gripAction.action.started += OnGripPressed;
        gripAction.action.canceled += OnGripUnpressed;
    }

    void OnTriggerPressed(InputAction.CallbackContext context)
    {
        anim.SetBool("TriggerPressed", true);
        Debug.Log("Trigger Pressed");
    }

    void OnTriggerUnpressed(InputAction.CallbackContext context)
    {
        anim.SetBool("TriggerPressed", false);
        Debug.Log("Trigger UnPressed");
    }

    void OnGripPressed(InputAction.CallbackContext context)
    {
        anim.SetBool("GripPressed", true);
        Debug.Log("Grip Pressed");
    }

    void OnGripUnpressed(InputAction.CallbackContext context)
    {
        anim.SetBool("GripPressed", false);
        Debug.Log("Grip UnPressed");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
