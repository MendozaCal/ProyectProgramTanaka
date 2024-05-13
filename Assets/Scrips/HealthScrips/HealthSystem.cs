using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class HealthSystem : Health
{
    public int damageEnemyBullet1 = 10;
    public int damageEnemyBullet2 = 20;
    public int damageSuicideEnemy = 50;
    public int healthItem = 20;
    public GameObject HealthItem;

    void Update()
    {
        health = Mathf.Max(health, 0);
        health = Mathf.Min(health, 100);
        if (health <= 0)
        {
            Destroy(gameObject);
        }        
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("damageSuicideEnemy"))
        {
            health -= damageSuicideEnemy;
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("HealthItem"))
        {
            health += healthItem;
            HealthItem.IsDestroyed();
        }
        if (other.gameObject.CompareTag("damageEnemyBullet1"))
        {
            health -= damageEnemyBullet1;
        }
        if (other.gameObject.CompareTag("damageEnemyBullet2"))
        {
            health -= damageEnemyBullet2;
        }
    }
}
