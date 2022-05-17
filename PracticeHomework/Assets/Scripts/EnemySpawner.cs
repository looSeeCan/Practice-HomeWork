using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject enemyPrefab;//1
    public Transform[] enemySpawnPoints;//1 several transforms
    public float enemyProjectileForce;//1 

    //make our selves a timer
    public float timeBetweenSpawns;//2
    float timer;//2

    // Start is called before the first frame update
    void Start()
    {
        timer = 0f; //03 
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;//4
        if(timer > timeBetweenSpawns)
        {
            timer += 0f;
            //spawn
            Transform chosenTransform = enemySpawnPoints[Random.Range(0, enemySpawnPoints.Length)];
            GameObject spawnedEnemy = Instantiate(enemyPrefab, chosenTransform.position, chosenTransform.rotation);
            spawnedEnemy.GetComponent<Rigidbody>().AddForce(spawnedEnemy.transform.forward * enemyProjectileForce, ForceMode.VelocityChange);
        }
    }
}
