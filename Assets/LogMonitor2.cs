using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LogMonitor2 : MonoBehaviour
{
    // Will be used to store a reference to the text mesh component
    private TextMesh textMesh;

    // Use this for initialization
    void Awake()
    {
        // Get the instance of the TextMesh component on this game object and store it
        textMesh = gameObject.GetComponentInChildren<TextMesh>();
    }

    // Called by Unity when this object is enabled in the scene
    void OnEnable()
    {
        // Attach the LogMessage function as a callback for the logMessageReceived event in Unity
        Application.logMessageReceived += LogMessage;
    }

    // Called by Unity when this object is disabled in the scene
    void OnDisable()
    {
        Application.logMessageReceived -= LogMessage;
    }

    public void LogMessage(string message, string stackTrace, LogType type)
    {
        // Set the text
        textMesh.text = message;
    }

    private void Update()
    {
        //Debug.Log();
    }
}
