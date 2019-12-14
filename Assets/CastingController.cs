using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CastingController : MonoBehaviour
{
    public float moveForce;
    public GameObject bullet;
    public Transform gun;
    public float shootRate;
    public float shootForce;
    private float m_shootRateTimeStamp;
    Animator m_Animator;
    private AudioSource fireCast;
    private void Start()
    {
        fireCast = GetComponent<AudioSource>();
    }


    // Update is called once per frame
    void Update()
    {
        if (OVRInput.GetDown(OVRInput.Button.Three))
        {
            if (Time.time > m_shootRateTimeStamp)
            {
                GameObject go = (GameObject)Instantiate(
                bullet, gun.position, gun.rotation);
                go.GetComponent<Rigidbody>().AddForce(gun.forward * shootForce);
                m_shootRateTimeStamp = Time.time + shootRate;
                fireCast.Play();
            }
        }
    }
}
