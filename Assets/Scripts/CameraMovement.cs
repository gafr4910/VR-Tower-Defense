using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CameraMovement : MonoBehaviour
{

    public GameObject parent;
    //public GameObject teleportPreview;
    //public GameObject mocapObject;
    public Image damageImage;
    public float flashSpeed = 5f;
    public Color flashColor = new Color(1f, 0f, 0f, 0.1f);
    public bool damaged = false;
    public float lastDamage;
    public float damageTime;
    public int hitsTaken = 0;
    public int maxHits = 5;
    public bool isDead = false;

    private bool previewExists = false;
    private int targetLayer = 1 << 8; // Layer 8 (targets)


    void Start()
    {
        lastDamage = Time.time;
    }

    void Update()
    {
        // When we have a horizontal value
        if (Input.GetAxis("Horizontal") != 0) 
        {
            // Move the attached parent based on the right vector of this object multiplied by the horizontal axis value
            parent.transform.position += (transform.right) * Input.GetAxis("Horizontal") *0.25f;
        }

        // When we have a vertical value
        if (Input.GetAxis("Vertical") != 0) 
        {
            // Move the attached parent based on the right vector of this object multiplied by the horizontal axis value
            parent.transform.position += (transform.forward) * Input.GetAxis("Vertical") * 0.25f;

        }

        // if(Input.GetAxis("Fire1") != 0) 
        // {
        //     //print("click");
        //     // The Unity raycast hit object, which will store the output of our raycast
        //     RaycastHit hit;
        //     //Debug.Log("?");
        //     // Does the ray intersect any objects excluding the player layer
        //     // Parameters: position to start the ray, direction to project the ray, output for raycast, limit of ray length, and layer mask
        //     if (Physics.Raycast(transform.position, transform.forward, out hit, Mathf.Infinity, targetLayer)) 
        //     {
        //         // The object we hit will be in the collider property of our hit object.
        //         // We can get the name of that object by accessing it's Game Object then the name property
        //         //Debug.Log(hit.point);
        //         //print(hit.point.x,);
        //         teleportPreview.transform.position = new Vector3(hit.point.x, -3f, hit.point.z);
        //         previewExists = true;
        //         //parent.transform.position = new Vector3(hit.point.x, 0, hit.point.z);
        //     }
        // }

        // else if(previewExists && Input.GetAxis("Fire1") == 0)
        // {
        //     //print("release");
        //     teleportPreview.transform.position = new Vector3(teleportPreview.transform.position.x, -5, teleportPreview.transform.position.z);
        //     this.transform.position = new Vector3(teleportPreview.transform.position.x, this.transform.position.y, teleportPreview.transform.position.z);
        //     previewExists = false;
        // }

        // if (getDamage)
        // {
        //     Color Opaque = new Color(1, 1, 1, 1);
        //     bloodImage.color = Color.Lerp(bloodImage.color, Opaque, 20 * Time.deltaTime);
        //     if (bloodImage.color.a >= 0.8) //Almost Opaque, close enough
        //     {
        //         getDamage = false;
        //     }
        // }
        // if (!getDamage)
        // {
        //     Color Transparent = new Color(1, 1, 1, 0);
        //     bloodImage.color = Color.Lerp(bloodImage.color, Transparent, 20 * Time.deltaTime);
        // }

        // If the player has just been damaged...
        if(damaged)
        {
            // ... set the colour of the damageImage to the flash colour.
            damageImage.color = flashColor;
            Debug.Log((Time.time - lastDamage));
            if((Time.time - lastDamage) < damageTime)
            {
                hitsTaken++;
            }
            else
            {
                hitsTaken = 1;
            }

            lastDamage = Time.time;

            // if((hitsTaken < maxHits) && ((Time.time - lastDamage) < damageTime))
            // {
            //     lastDamage = Time.time;
            // }
            if(hitsTaken == maxHits)
            {
                isDead = true;
                Debug.Log("Death");
            }
        }
        // Otherwise...
        else
        {
            // ... transition the colour back to clear.
            damageImage.color = Color.Lerp (damageImage.color, Color.clear, flashSpeed * Time.deltaTime);
        }

        // Reset the damaged flag.
        damaged = false;
    }
}

