using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CatMage : MonoBehaviour
{
    public float speed;
    public float lifetime;
    public float distance;
    public int damage;
    public LayerMask enemy;


    public void SearchEnemy()
    {
        Transform nearestEnemy = null;
        float nearestEnemyDistance = Mathf.Infinity;

        foreach(GameObject enemy in GameObject.FindGameObjectsWithTag("Enemy"))
        {
            float curdistance = Vector2.Distance(transform.position, enemy.transform.position);
            if(curdistance < nearestEnemyDistance) 
            { 
            nearestEnemy = enemy.transform;
            nearestEnemyDistance = curdistance;
            }
        }
        if (nearestEnemy != null)
        {
            FireCast(nearestEnemy);
        }
            
    }
    public void FireCast(Transform enemy)
    {
        
    }

}

