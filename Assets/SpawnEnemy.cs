using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemy : MonoBehaviour
{
    public GameObject Enemy;

    private int PlayerHealth;

    public float SpawnRate1;
    public float SpawnRate2;
    public float SpawnRate3;
    public float SpawnRate4;
    public float SpawnRate5;

    public int NumberOfEnemies1;
    public int NumberOfEnemies2;
    public int NumberOfEnemies3;
    public int NumberOfEnemies4;
    public int NumberOfEnemies5;

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
        if(spawnTimer >= SpawnRate1 && CurrentEnemies < NumberOfEnemies1 && Level == 1)
        {
            SpawnEnemies();
            spawnTimer = 0f;
            CurrentEnemies++;
            
        }
        if (CurrentEnemies >= NumberOfEnemies1 && Level == 1)
        {
            Level++;
        }

        //level 2
        if (spawnTimer >= SpawnRate2 && CurrentEnemies < NumberOfEnemies2 && Level == 2)
        {
            SpawnEnemies();
            spawnTimer = 0f;
            CurrentEnemies++;
            
        }
        if (CurrentEnemies >= NumberOfEnemies2 && Level == 2)
        {
            Level++;
        }

        //level 3
        if (spawnTimer >= SpawnRate3 && CurrentEnemies < NumberOfEnemies3 && Level == 3)
        {
            SpawnEnemies();
            spawnTimer = 0f;
            CurrentEnemies++;
            
        }
        if (CurrentEnemies >= NumberOfEnemies3 && Level == 3)
        {
            Level++;
        }

        //level4
        if (spawnTimer >= SpawnRate4 && CurrentEnemies < NumberOfEnemies4 && Level == 4)
        {
            SpawnEnemies();
            spawnTimer = 0f;
            CurrentEnemies++;
            
        }
        if (CurrentEnemies >= NumberOfEnemies4 && Level == 4)
        {
            Level++;
        }

        //level5
        if (spawnTimer >= SpawnRate5 && CurrentEnemies < NumberOfEnemies5 && Level == 5)
        {
            SpawnEnemies();
            spawnTimer = 0f;
            CurrentEnemies++;
            
        }
        if (CurrentEnemies >= NumberOfEnemies5 && Level == 5)
        {
            Level++;
        }

        //else
        //{
        //    Level++;
        //    SpawnRate *= 2;
        //    CurrentEnemies = 0;
        //}
        ////level2
        //if (spawnTimer >= SpawnRate && CurrentEnemies < NumberOfEnemies && Level == 2)
        //{
        //    SpawnEnemies();
        //    spawnTimer = 0f;
        //    CurrentEnemies++;
        //}

    }

    void SpawnEnemies()
    {

        Instantiate(Enemy);

    }


}
