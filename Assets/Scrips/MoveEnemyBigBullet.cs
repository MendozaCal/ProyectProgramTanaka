using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveEnemyBigBullet : AtackRangeEnemy
{
    protected override void Aim()
    {
        if (Player != null && Vector3.Distance(transform.position, Player.position) >= distanceAtack)
        {
            cont += Time.deltaTime;
            if (cont >= 2)
            {
                ShootEnemy();
                cont = 0;
            }
        }
    }
    /*protected override void Move()
    {
        if (Player != null && Vector3.Distance(transform.position, Player.position) >= distanceAtack)
        {
            Vector3 direction = Player.position + transform.position;
            direction.Normalize();
            transform.position += direction * maxSpeed * Time.deltaTime;
            transform.LookAt(Player.position);
        }
    }*/
}
