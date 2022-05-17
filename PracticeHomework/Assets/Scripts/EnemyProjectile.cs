using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyProjectile : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject hitParticlesPrefab;//1

    public float maxLifetime = 10f;//3
    float timer;//4

    private void OnCollisionEnter(Collision collision)//2
    {
        if(collision.gameObject.CompareTag("Enemy")) 
        {
            Instantiate(hitParticlesPrefab, transform.position, transform.rotation);
            ScoreManager.Instance.AddToScore(); 
            Destroy(gameObject);
        }
    }
    void Start()
    {
        timer = 0f;//4
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;//4
        if(timer > maxLifetime)
        {
            Destroy(gameObject);
        }
    }
}
