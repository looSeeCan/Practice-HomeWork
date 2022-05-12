using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectableCube : MonoBehaviour
{
    //when you run over the cube you are going to disable the mesh renderer and disable the collider
    MeshRenderer rend;//make a reference the the renderer
    BoxCollider collider;// make a reference to the collider. remember that BoxCollider is the type

    // Start is called before the first frame update
    void Start()
    {
        rend = GetComponent<MeshRenderer>();
        collider = GetComponent<BoxCollider>();
    }

    //write a new method
    private void OnTriggerEnter(Collider other)//when something is blue, unity will trigger it for us
    {
        if(other.gameObject.CompareTag("Player"))//compares the tag of the object. if the Player collides with the object
        {
            Debug.Log("Collided with the player");//log in the console, so we know
            rend.enabled = false;//disable the rederer so we can't see it anymore
            collider.enabled = false;//disable the collider so we can not collide with it anymore
            CollectableManager.Instance.AddOneToCount();//call this method
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
