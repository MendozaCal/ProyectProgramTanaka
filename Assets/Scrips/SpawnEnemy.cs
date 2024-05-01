using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using UnityEngine.Rendering;

public class SpawnEnemy : MonoBehaviour
{
    public GameObject[] Enemys;
    public Transform spawnPoint;
    public float spawnDelay = 2;
    public float time = 0;
    public Transform Player;

    void Update()
    {
        time += Time.deltaTime;
        if(Player != null && time >= spawnDelay)
        {
            spawnEnemy();
            time = 0;
        }
    }
    void spawnEnemy()
    {
        int randomIndex = Random.Range(0, Enemys.Length);
        GameObject enemyToSpawn = Enemys[randomIndex];
        Instantiate(enemyToSpawn);
    }

}
