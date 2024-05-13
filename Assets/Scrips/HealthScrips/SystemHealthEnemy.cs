using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SystemHealthEnemy : Health
{
    [SerializeField] protected GameObject[] prefapItems;
    private bool isDead = false;
    private void Update()
    {
        if (!isDead && health <= 0)
        {
            isDead = true;
            if (prefapItems.Length > 0)
            {
                int randomIndex = Random.Range(0, prefapItems.Length);
                Instantiate(prefapItems[randomIndex], transform.position, Quaternion.identity);
            }
            Destroy(this.gameObject);
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Bullet1"))
        {
            health -= 50;
        }
        if (other.gameObject.CompareTag("Bullet2"))
        {
            health -= 100;
        }
    }
}