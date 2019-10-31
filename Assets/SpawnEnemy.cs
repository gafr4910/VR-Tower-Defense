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

    private int Level;

    // Start is called before the first frame update
    void Start()
    {
        //SpawnRate = 3f;
        Level = 1;
    }

    // Update is called once per frame
    void Update()
    {
        spawnTimer += Time.deltaTime;
        //level 1
        if(spawnTimer >= SpawnRate && CurrentEnemies < NumberOfEnemies && Level == 1)
        {
            SpawnEnemies();
            spawnTimer = 0f;
            CurrentEnemies++;
        }
        else
        {
            Level++;
            SpawnRate *= 2;
            CurrentEnemies = 0;
        }
        //level2
        if(spawnTimer >= SpawnRate && CurrentEnemies < NumberOfEnemies && Level == 2)
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
