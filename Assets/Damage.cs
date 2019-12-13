using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Damage : MonoBehaviour
{
    //public float delay = 2.0f;

    const float m_dropChance = 1f / 10f;

    const float weapon_drop = 1f / 3f;

    public GameObject[] Weapons;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter(Collider col)
    {
        //all projectile colliding game objects should be tagged "Enemy" or whatever in inspector but that tag must be reflected in the below if conditional
        if (col.gameObject.tag == "Enemy")
        {
            OnEnemyJustDied(col);
            Destroy(col.gameObject);
            AudioSource audio = GetComponent<AudioSource>();

            audio.Play();  // plays sound when collided

        }

    }

    public void OnEnemyJustDied(Collider col)
    {
        if (Random.Range(0f, 1f) <= m_dropChance)
        {
            
        }
    }
}
