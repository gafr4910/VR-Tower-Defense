using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyBehavior : MonoBehaviour
{

    private BoxCollider enemyHitbox;
    private Rigidbody enemyRigidBody;

    //player's location
    //public Transform playerPosition = GameObject.FindGameObjectWithTag("Player").transform;
    //public Transform exitPosition = GameObject.FindGameObjectWithTag("Exit").transform;

    private GameObject Enemy;
    private GameObject Player;

    EnemyUnit BasicEnemy;



    // Start is called before the first frame update
    void Start()
    {
        Enemy = GameObject.FindGameObjectWithTag("Enemy");
        Player = GameObject.FindGameObjectWithTag("Player");

        BasicEnemy = this.GetComponent<EnemyUnit>();

    }

    // Update is called once per frame
    void Update()
    {
      if(BasicEnemy.health > 0)
        {
            BasicEnemy.MoveToPlayer();
        }
    }
}

public class EnemyUnit : MonoBehaviour
{
    public Transform target;
    public float speed;
    public int health;

    private void Start()
    {
        this.StopMoving();
    }

    private void Update()
    {
        
    }

    public void MoveToPlayer()
    {
        //find player
        transform.LookAt(target.position);
        //rotate towards player
        //transform.Rotate(new Vector3(0, -90, 0), Space.Self);
        if (this.health > 0)
        {
            transform.Translate(new Vector3(speed * Time.deltaTime, 0, 0));
        }
    }

    public void StopMoving()
    {

    }
}
