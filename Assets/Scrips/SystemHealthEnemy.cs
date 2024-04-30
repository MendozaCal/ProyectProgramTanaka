using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SystemHealthEnemy : MonoBehaviour
{   
    public int healthEnemy = 100;

    private void Update()
    {
        if(healthEnemy <= 0)
        {
            Destroy(gameObject);
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Bullet1"))
        {
            healthEnemy -= 50;
        }
        if (other.gameObject.CompareTag("Bullet2"))
        {
            healthEnemy -= 100;
        }
    }

}
