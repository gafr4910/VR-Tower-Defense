﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyController : MonoBehaviour
{
    public delegate void EnemyKilled();
    public static event EnemyKilled OnEnemyKilled;




    public GameObject leftHand;
    public GameObject rightHand;
    private AudioSource DeathSound;
    public bool isDead = false;
    private NavMeshAgent Mob;
    private GameObject Player;
    public float MobDistanceRun = 100f;
    public float attackTime = 5f;
    public float lastAttack;




    // Start is called before the first frame update
    void Start()
    {
        Player = GameObject.FindWithTag("Player");
        DeathSound = GetComponent<AudioSource>();
        Mob = GetComponent<NavMeshAgent>();
        lastAttack = Time.time;
    }

    // Update is called once per frame
    void Update()
    {
        float distance = Vector3.Distance(transform.position, Player.transform.position);

        if(distance < MobDistanceRun && distance > 1.4f && isDead == false)
        {
            leftHand.GetComponent<SphereCollider>().enabled = false;
            rightHand.GetComponent<SphereCollider>().enabled = false;
            GetComponent<Animator>().SetBool("FarAway", true);
            Vector3 dirToPlayer = transform.position - Player.transform.position;
            Vector3 newPos = transform.position - dirToPlayer;
            Mob.SetDestination(newPos);
        }else if (distance <= 1.4f)
        {

            GetComponent<Animator>().SetTrigger("Attack");
            GetComponent<Animator>().SetBool("FarAway", false);
            leftHand.GetComponent<SphereCollider>().enabled = true;
            rightHand.GetComponent<SphereCollider>().enabled = true;
        }

    }

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag == "Mace")
        {
            Die();
        }
    }

    public void Die()
    {
        isDead = true;
        DeathSound.Play();
        GetComponent<CapsuleCollider>().enabled = false;
        GetComponent<Animator>().enabled = false;
        Destroy(gameObject, 3f);
        if (OnEnemyKilled != null)
        {
            OnEnemyKilled();
            
        }
        
    }
}
