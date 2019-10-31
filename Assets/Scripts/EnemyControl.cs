using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyControl : MonoBehaviour
{

    public float speed = 0.1f;
    public int health = 1;
    public Transform ExitPosition;
    public Transform StartPosition;

    private Transform EnemyPos;
    // Start is called before the first frame update
    void Start()
    {
        ExitPosition = GameObject.FindGameObjectWithTag("Exit").transform;

        StartPosition = GameObject.FindGameObjectWithTag("Entrance").transform;

        transform.position = new Vector3(11.0f, 1.0f, 1.0f);
    }

    // Update is called once per frame
    void Update()
    {
        
        if (health > 0)
        {
            transform.position = Vector3.MoveTowards(transform.position, ExitPosition.localPosition, speed);
            
        }
    }

    //void OnCollisionEnter(Collision collision)
    //{
    //    if(collision.gameObject.tag == "Weapon")
    //    {
    //        Debug.Log("Enemy hit");
    //        Destroy(this.gameObject);
    //    }
    //}
}
