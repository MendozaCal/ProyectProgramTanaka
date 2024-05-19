using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class BuyStructure : Store
{
    float timer = 0;
    private void Start()
    {
        Coins.text = coin.ToString();
        Menú.SetActive(false);
        StructureHealth.SetActive(false);
        StructureCoin.SetActive(false);
        StructureBullets.SetActive(false);
        Tower1.SetActive(false);
        Tower2.SetActive(false);
        Tower3.SetActive(false);
    }
    private void Update()
    {
        Coins.text = coin.ToString();
        coin = Mathf.Max(0, coin);
        inventary();
    }
    public void BuyStructureHealth()
    {
        if(coin >= 20)
        {
            coin -= 20;
            StructureHealth.SetActive(true);
            timer = Time.time;
            if (timer >= 10)
            {
                StructureHealth.SetActive(false);
            }
        }
    }
    public void BuyStructureCoin()
    {
        if (coin >= 20)
        {
            coin -= 20;
            StructureCoin.SetActive(true);
            timer = Time.time;
            if (timer >= 10)
            {
                StructureCoin.SetActive(false);
            }
        }
    }
    public void BuyStructureBullets()
    {
        if (coin >= 20)
        {
            coin -=20;
            StructureBullets.SetActive(true);
            timer = Time.time;
            if (timer >= 10)
            {
                StructureBullets.SetActive(false);
            }
        }
    }
    public void BuyTower1()
    {
        if (coin >= 10)
        {
            coin -= 10;
            Tower1.SetActive(true);
        }
    }
    public void BuyTower2()
    {
        if (coin >= 10)
        {
            coin -= 10;
            Tower2.SetActive(true);
        }
    }
    public void BuyTower3()
    {
        if (coin >= 10)
        {
            coin -= 10;
            Tower3.SetActive(true);
        }
    }

}
