using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AtackRangeEnemy : MoveEnemy
{
    [SerializeField] protected GameObject prefab;
    [SerializeField] protected Transform shootPoint;
    protected float cont;
    void Update()
    {
        Aim();
        Move();
    }
    protected virtual void Aim()
    {
        if (Player != null && Vector3.Distance(transform.position, Player.position) <= distanceAtack)
        {
            cont += Time.deltaTime;
            if (cont >= 2)
            {
                ShootEnemy();
                cont = 0;
            }
        }
    }
    public void ShootEnemy()
    {
        transform.LookAt(Player.position);
        GameObject obj = Instantiate(prefab);
        obj.transform.position = shootPoint.position;
        obj.GetComponent<Bullet>().SetDirection(shootPoint.forward);
    }
}
