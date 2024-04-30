using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShoot : MonoBehaviour
{
    [SerializeField] private GameObject prefab;
    [SerializeField] private GameObject prefab2;
    [SerializeField] private Transform shootPoint;
    [SerializeField] private Transform shootPoint2;
    public int contBullet1 = 20;
    public int contBullet2 = 10;
    int inicialBullet1;
    int inicialBullet2;
    public GameObject Bullet1;
    public GameObject Bullet2;
    private void Start()
    {
        inicialBullet1 = contBullet1;
        inicialBullet2 = contBullet2;
    }
    void Update()
    {
        contBullet1 = Mathf.Max(contBullet1, 0);
        contBullet2 = Mathf.Max(contBullet2, 0);
        Shoot();
    }

    void Shoot()
    {
        if (Input.GetMouseButtonDown(0))
        {
            contBullet1--;
            if(contBullet1 >= 0)
            {
                GameObject obj = Instantiate(prefab);
                obj.transform.position = shootPoint.position;
                obj.GetComponent<Bullet>().SetDirection(shootPoint.forward);
            }
        }
        if (Input.GetMouseButtonDown(1))
        {
            contBullet2--;
            if (contBullet2 >= 0)
            {
                GameObject obj = Instantiate(prefab2);
                obj.transform.position = shootPoint.position;
                obj.GetComponent<Bullet>().SetDirection(shootPoint.forward);
            }
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Bullets1"))
        {
            contBullet1 = inicialBullet1;
            Bullet1.SetActive(false);
            StartCoroutine(BulletsItem(Bullet1));
        }
        if (other.gameObject.CompareTag("Bullets2"))
        {
            contBullet2 = inicialBullet2;
            Bullet2.SetActive(false);
            StartCoroutine(BulletsItem(Bullet2));
        }
    }
    IEnumerator BulletsItem(GameObject item)
    {
        yield return new WaitForSeconds(5);
        item.SetActive(true);
    }
}

