using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyControl : MonoBehaviour
{

    public float speed = 0.1f;
    public int health = 10;
    public Transform ExitPosition;
    public Transform StartPosition;

    public GameObject player;

    private Transform EnemyPos;
    // Start is called before the first frame update
    void Start()
    {

        int randomIndex = Random.Range(1, 4);

        
        

        ExitPosition = GameObject.FindGameObjectWithTag("Exit").transform;

        StartPosition = GameObject.FindGameObjectWithTag("Entrance").transform;
        if(randomIndex == 1)
        {
            transform.position = new Vector3(-90.0f, 0.2f, -1.0f);
        }
        else if(randomIndex == 2)
        {
            transform.position = new Vector3(-90.0f, 0.2f, 1.0f);
        }
        else if(randomIndex == 3)
        {
            transform.position = new Vector3(-90.0f, 0.2f, 3.0f);
        }
    }

    // Update is called once per frame
    void Update()
    {
        player = GameObject.Find("OVRPlayerController");
        CameraMovement pCam = player.GetComponent<CameraMovement>();

        //pCam.damaged = true;

        if (health > 0)
        {
            transform.position = Vector3.MoveTowards(transform.position, ExitPosition.localPosition, speed);
            
        }
        
    }

    void OnTriggerEnter(Collider col)
    {
        //all projectile colliding game objects should be tagged "Enemy" or whatever in inspector but that tag must be reflected in the below if conditional
        if (col.gameObject.tag == "Weapon")
        {
            

        }

    }


}
