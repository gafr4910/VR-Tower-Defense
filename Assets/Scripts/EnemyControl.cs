using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyControl : MonoBehaviour
{

    public float speed = 0.1f;
    public int health = 1;
    public Transform ExitPosition;

    private Transform EnemyPos;
    // Start is called before the first frame update
    void Start()
    {
        //ExitPosition = GameObject.FindGameObjectWithTag("Exit").transform;

        //transform.position = new Vector3(0.0f, 0.0f, 0.0f);
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log(ExitPosition.position);
        if (health > 0)
        {
            transform.position = Vector3.MoveTowards(transform.position, ExitPosition.localPosition, speed);
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.name == "Player")
        {
            Debug.Log("Hit Player");
            Destroy(this.gameObject);
        }
    }
}
