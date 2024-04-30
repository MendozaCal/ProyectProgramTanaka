using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AtackRangeEnemy : MonoBehaviour
{
    public Transform Player;
    //public float speed = 5;
    public float distanceAtack = 20;
    [SerializeField] private GameObject prefab;
    [SerializeField] private Transform shootPoint;
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
        }
    }
    void ShootEnemy()
    {
        transform.LookAt(Player.position);

        GameObject obj = Instantiate(prefab);
        obj.transform.position = shootPoint.position;
        obj.GetComponent<Bullet>().SetDirection(shootPoint.forward);
    }
}
