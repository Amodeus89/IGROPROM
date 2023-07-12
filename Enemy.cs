using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public int health;
    private ScoreManager sm;
    public float speed;

    private void Start()
    {
        sm = FindObjectOfType<ScoreManager>();
    }
    private void Update()
    {
        if (health <= 0)
        {
            sm.Kill();
            Destroy(gameObject);
        }
        transform.Translate(Vector2.left * speed * Time.deltaTime);
    }
        public void TakeDamage(int damage)
    { 
        health -= damage;
    }
  }
