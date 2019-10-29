using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{

    public GameObject parent;
    public GameObject teleportPreview;
    private bool previewExists = false;
    private bool isGrabbing = false;
    private int targetLayer = 1 << 8; // Layer 8 (targets)


    void Start()
    {
        
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

        if(Input.GetAxis("Fire1") != 0) 
        {
            //print("click");
            // The Unity raycast hit object, which will store the output of our raycast
            RaycastHit hit;
            //Debug.Log("?");
            // Does the ray intersect any objects excluding the player layer
            // Parameters: position to start the ray, direction to project the ray, output for raycast, limit of ray length, and layer mask
            if (Physics.Raycast(transform.position, transform.forward, out hit, Mathf.Infinity, targetLayer)) {
                // The object we hit will be in the collider property of our hit object.
                // We can get the name of that object by accessing it's Game Object then the name property
                //Debug.Log(hit.point);
                //print(hit.point.x,);
                teleportPreview.transform.position = new Vector3(hit.point.x, -3f, hit.point.z);
                previewExists = true;
                //parent.transform.position = new Vector3(hit.point.x, 0, hit.point.z);
            }
        }

        else if(previewExists && Input.GetAxis("Fire1") == 0)
        {
            //print("release");
            teleportPreview.transform.position = new Vector3(teleportPreview.transform.position.x, -5, teleportPreview.transform.position.z);
            this.transform.position = new Vector3(teleportPreview.transform.position.x, this.transform.position.y, teleportPreview.transform.position.z);
            previewExists = false;
        }

        // if(Input.GetAxis("Fire1") != 0)
        // {
        //     //Debug.Log("h");
        //     RaycastHit hit;
        //     if (Physics.Raycast(transform.position, transform.forward, out hit, Mathf.Infinity, targetLayer)) {
        //         //Debug.Log("?");
        //         if(isGrabbing)
        //         {
        //             Vector3 grabPos = transform.position + transform.forward * 3;
        //             hit.collider.transform.position = grabPos;
        //         }
        //         else if(hit.collider.tag == "Grabbable")
        //         {
        //             //Debug.Log("yep");
        //             Vector3 grabPos = transform.position + transform.forward * 3;
        //             hit.collider.transform.position = grabPos;
        //             isGrabbing = true;
        //         }
        //     }
        // }
        // else if(!Input.GetKeyDown(KeyCode.H))
        // {
        //     if(isGrabbing)
        //     {
        //         isGrabbing = false;
        //     }
        // }
    }
}

