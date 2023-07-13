using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject[] variants;

    private float timeBtwSpawn;
    public float startTimeSpawn;
    public float decreaseTime;
    public float minTime;

    public float enemyHealth;
    public float increaseHealth;

    private void Update()
    {
        enemyHealth += Time.deltaTime * increaseHealth;

        if(timeBtwSpawn <= 0 )
         { 
           int rand = Random.Range( 0, variants.Length );
           Instantiate(variants[rand], transform.position, Quaternion.identity);
           timeBtwSpawn = startTimeSpawn;
           if(startTimeSpawn > minTime)
             {
                startTimeSpawn -= decreaseTime;
             }
        }
        else
        {
            timeBtwSpawn -= Time.deltaTime;
        }
    }
}
