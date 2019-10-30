using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemy : MonoBehaviour
{
    public GameObject Enemy;

    private int PlayerHealth;

    public float SpawnRate;

    public int NumberOfEnemies;

    private int CurrentEnemies = 0;

    private float spawnTimer;

    // Start is called before the first frame update
    void Start()
    {
        //SpawnRate = 3f;
    }

    // Update is called once per frame
    void Update()
    {
        spawnTimer += Time.deltaTime;

        if(spawnTimer >= SpawnRate && CurrentEnemies < NumberOfEnemies )
        {
            SpawnEnemies();
            spawnTimer = 0f;
            CurrentEnemies++;
        }
        
    }

    void SpawnEnemies()
    {

        Instantiate(Enemy);

    }


}
