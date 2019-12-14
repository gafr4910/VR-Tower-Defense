using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayAgain : MonoBehaviour
{
    void Update()
    {
        Debug.Log("end scene");
        if (OVRInput.GetDown(OVRInput.Button.Three) || Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("ended");
            SceneManager.LoadScene("OculusTestArea");
        }
    }
}
