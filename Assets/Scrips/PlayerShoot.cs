using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShoot : MonoBehaviour
{
    [SerializeField] private GameObject prefab;
    [SerializeField] private Transform shootPoint;
    public int contBullet = 20;
    int inicialBullet;
    private void Start()
    {
        inicialBullet = contBullet;
    }
    void Update()
    {
        contBullet = Mathf.Max(contBullet, 0);
        Shoot();
    }

    void Shoot()
    {
        if (Input.GetMouseButtonDown(0))
        {
            contBullet--;
            if(contBullet >= 0)
            {
                GameObject obj = Instantiate(prefab);
                obj.transform.position = shootPoint.position;
                obj.GetComponent<Bullet>().SetDirection(shootPoint.forward);
            }
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Bullets"))
        {
            contBullet = inicialBullet;
        }
    }
}
