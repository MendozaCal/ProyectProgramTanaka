using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AtackSuicideEnemy : MonoBehaviour
{
    public Transform Player;
    public float speed = 5;
    public float distanceAtack = 20;
    public HealthSystem healthSystem;
    void Update()
    {
        if (Player != null && Vector3.Distance(transform.position, Player.position) <= distanceAtack)
        {
            MoveEnemy();
        }
    }
    void MoveEnemy()
    {
        Vector3 direction = Player.position - transform.position;
        direction.Normalize();
        transform.position += direction * speed * Time.deltaTime;

        transform.LookAt(Player.position);
    }
}
