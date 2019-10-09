using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PenStroke : MonoBehaviour
{
    private GameObject currentStroke; // Holds the current stroke being drawn
    public GameObject strokePrefab; // Reference to the stroke prefab we created before
    private bool isDrawing = false;
    public float minDistance = 0.01f; // Distance required to move the pen before a point will be added

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Check if button is down
        if(Input.GetButtonDown("Fire1")) {
            isDrawing = true;
            // Create new stroke
            currentStroke = Instantiate(strokePrefab);
        }
        
        if(Input.GetButtonUp("Fire1"))
        {
            isDrawing = false;
        }

        // While the pen is drawing
        if (isDrawing) {
            // Get a reference to the line renderer
            LineRenderer line = currentStroke.GetComponent<LineRenderer>();

            // Automatically add a point if there are no positions
            if (line.positionCount == 0) {
                line.positionCount += 1;
                line.SetPosition(line.positionCount - 1, transform.position);
            } else {
                // Get a reference to the last point added
                Vector3 lastPosition = line.GetPosition(line.positionCount - 1);
                // compute a vector that points from the last position to the current position
                Vector3 distanceVec = transform.position - lastPosition;
                
                // Add a point if the current position is far enough away
                if (distanceVec.sqrMagnitude > minDistance * minDistance) {
                    line.positionCount += 1;
                    line.SetPosition(line.positionCount - 1, transform.position);
                }
            }
        }

    }
}
