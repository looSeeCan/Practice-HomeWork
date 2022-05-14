using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FiringPad : MonoBehaviour
{
    public GameObject projectilePrefab;//1 first declare a reference to the projectile that we want to fire
    public Transform spawnpoint;//1
    public float projectileForce;//4
    private void OnTriggerEnter(Collider other)
    {

        if(other.gameObject.CompareTag("Player"))
        {
            // Debug.Log("Whenever you have a OnTriggerEnter, use a debug.log message to make sure the interaction works.");
            //2 declare a game object. instantiate this projectilePrefab at the position of spawnpoint
            GameObject spawnedProjectile = Instantiate(projectilePrefab, spawnpoint.position, spawnpoint.rotation);
            //3 Add force to this projectile that we just spawned. AddForce is a method. add force in the direction that spawnedProjectile is facing
            // multiply it by projectile force projectileForce. in addition to this we add a ForceMode. A way to add force without making any chnages to other things
            spawnedProjectile.GetComponent<Rigidbody>().AddForce(spawnedProjectile.transform.forward * projectileForce, ForceMode.VelocityChange);
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
