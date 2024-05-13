using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Store : MonoBehaviour
{
    [SerializeField] protected int coin = 0;
    [SerializeField] protected int coinValor = 20;
    private void Update()
    {
        coin = Mathf.Max(0, coin);
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Coin"))
        {
            coin += coinValor;
            Destroy(this.gameObject);
        }
    }
}
