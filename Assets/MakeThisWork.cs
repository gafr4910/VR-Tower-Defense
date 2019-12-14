using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MakeThisWork : MonoBehaviour
{

    private void OnTriggerEnter(Collider collision)
    {
        if(collision.gameObject.tag == "Enemy")
        {
            Debug.Log("HELP ME WORK BITCH");
        }
    }


}
