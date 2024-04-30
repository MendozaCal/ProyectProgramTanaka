using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthSystem : MonoBehaviour
{
    public int health = 100;
    public int damageEnemyBullet1 = 10;
    public int damageEnemyBullet2 = 20;
    public int damageSuicideEnemy = 50;
    public int healthItem = 20;
    public GameObject HealthItem;

    void Update()
    {
        if (health <= 0)
        {
            Destroy(gameObject);
        }        
    }
    /*private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("damageEnemyBullet1"))
        {
            health -= damageEnemyBullet1;
        }
        if (collision.gameObject.CompareTag("damageEnemyBullet2"))
        {
            health -= damageEnemyBullet2;
        }
        if (collision.gameObject.CompareTag("damageSuicideEnemy"))
        {
            health -= damageSuicideEnemy;
        }
    }*/
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("HealthItem"))
        {
            health += healthItem;
            HealthItem.SetActive(false);
            StartCoroutine(ActiveHealth());
        }
    }
    IEnumerator ActiveHealth()
    {
        yield return new WaitForSeconds(5);
        HealthItem.SetActive(true);
    }
}
