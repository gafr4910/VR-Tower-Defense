using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemy : MonoBehaviour
{
    public GameObject Enemy;

    private int PlayerHealth;

    public int SpawnRate;

    private int NumberOfEnemies;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(NumberOfEnemies < 5)
        {
            Instantiate(Enemy);
            NumberOfEnemies++;
            

        }
        
    }

    
}
