using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieManager : MonoBehaviour
{


    public Transform[] m_SpawnPoints;
    public GameObject m_ZombiePrefab;
    private int currentNum;
    private int totalKills = -5;
    private int maxEnemy = 5;


    // Start is called before the first frame update
    void Start()
    {
        currentNum = GameObject.FindGameObjectsWithTag("Zombie").Length;
        SpawnNewEnemy();
    }

    // Update is called once per frame
    void Update()
    {
        if(currentNum <= maxEnemy)
        {

            SpawnNewEnemy();
            //Debug.Log("SPAWN BECAUSE LOW CURENNT NUM: ");
            //Debug.Log(currentNum);
        }

        if(totalKills == 5)
        {
            maxEnemy = maxEnemy + 2;
            Debug.Log("MAX ENEMY INCREASE");
        }else if(totalKills == 10){
            maxEnemy = maxEnemy + 3;
            Debug.Log("MAX ENEMY INCREASE");
        }
        else if (totalKills == 15)
        {
            maxEnemy = maxEnemy + 3;
            Debug.Log("MAX ENEMY INCREASE");
        }
        else if (totalKills == 20)
        {
            maxEnemy = maxEnemy + 3;
            Debug.Log("MAX ENEMY INCREASE");
        }

        currentNum = GameObject.FindGameObjectsWithTag("Zombie").Length;
        //Debug.Log("TOTAL KILLS: ");
        //Debug.Log(currentNum);
    }
   /*
    private void OnEnable()
    {
        EnemyController.OnEnemyKilled += SpawnNewEnemy;
        currentNum--;
        totalKills++;
        Debug.Log("TOTAL KILLS: ");
        Debug.Log(totalKills);
    }
   */

    void SpawnNewEnemy()
    {
        totalKills++;
        int randomNumber = Mathf.RoundToInt(Random.Range(0f, m_SpawnPoints.Length - 1));
        Instantiate(m_ZombiePrefab, m_SpawnPoints[randomNumber].transform.position, Quaternion.identity);

    }

}
