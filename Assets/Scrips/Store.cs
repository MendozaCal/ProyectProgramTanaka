using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Store : MonoBehaviour
{
    [SerializeField] protected int coin = 0;
    [SerializeField] protected int coinValor = 20;
    [SerializeField] protected TextMeshProUGUI Coins;
    [SerializeField] protected GameObject Menú;
    [SerializeField] protected GameObject StructureHealth;
    [SerializeField] protected GameObject StructureCoin;
    [SerializeField] protected GameObject StructureBullets;
    [SerializeField] protected GameObject Tower1;
    [SerializeField] protected GameObject Tower2;
    [SerializeField] protected GameObject Tower3;
    protected void inventary()
    {
        if (Input.GetKeyDown(KeyCode.Tab))
        {
            Menú.SetActive(true);
        }
        else if (Input.GetKeyUp(KeyCode.Tab))
        {
            Menú.SetActive(false);
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Coin"))
        {
            coin += coinValor;
            Destroy(other.gameObject);
        }
    }
}
