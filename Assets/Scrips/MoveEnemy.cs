using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveEnemy : MoveController
{
    protected override void Move()
    {
        if (Player != null && Vector3.Distance(transform.position, Player.position) <= distanceAtack)
        {
            Vector3 direction = Player.position - transform.position;
            direction.Normalize();
            transform.position += direction * maxSpeed * Time.deltaTime;
            transform.LookAt(Player.position);
        }
    }
}
