using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.VFX;

public class Point : MonoBehaviour
{
    public Enemy enemy;
    private Spawner spawner;

    private void Start()
    {
        spawner = FindObjectOfType<Spawner>();
        Instantiate(enemy, transform.position, transform.rotation);
        enemy.health = Mathf.RoundToInt(spawner.enemyHealth);
    }
}
