using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerLoseCondition : MonoBehaviour
{
    private void onTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Enemy"))
        {
            Debug.Log("An enemy has reached your base! You lose.");
        }
    }
}
