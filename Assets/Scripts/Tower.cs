using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tower : MonoBehaviour
{
    [Header("Set in Inspector:")]
        public float shotWaitTime = 3f;
        public GameObject projectilePrefab;

    private float nextShot;

    void Start()
    {
        nextShot = Time.time + shotWaitTime;
    }

    void Update()
    {
        if(Time.time >= nextShot)
        {
            GameObject go = Instantiate(projectilePrefab);
            Vector3 dir = new Vector3(this.gameObject.transform.position.x + 2, this.gameObject.transform.position.y + 1.5f, this.gameObject.transform.position.z);
            go.transform.position = dir;//this.gameObject.transform.position + new Vector3(3,0,0);
            Rigidbody rig = go.GetComponent<Rigidbody>();
            rig.velocity = new Vector3(50,0,0);
            nextShot = Time.time + shotWaitTime;
        }
    }
}
