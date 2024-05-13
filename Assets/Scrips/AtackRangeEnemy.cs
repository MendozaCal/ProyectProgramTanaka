using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AtackRangeEnemy : MoveEnemy
{
    [SerializeField] protected GameObject prefab;
    [SerializeField] protected Transform shootPoint;
    float cont;
    void Update()
    {
        if (Player != null && Vector3.Distance(transform.position, Player.position) <= distanceAtack)
        {
            cont += Time.deltaTime;
            if (cont >= 2)
            {
                ShootEnemy();
                cont = 0;
            }
            Move();
        }
    }
    void ShootEnemy()
    {
        transform.LookAt(Player.position);
        GameObject obj = Instantiate(prefab);
        obj.transform.position = shootPoint.position;
        obj.GetComponent<Bullet>().SetDirection(shootPoint.forward);
    }
    protected override void Move()
    {
        Vector3 direction = Player.position - transform.position;
        direction.Normalize();
        transform.position += direction * maxSpeed * Time.deltaTime;
        transform.LookAt(Player.position);
    }
}
