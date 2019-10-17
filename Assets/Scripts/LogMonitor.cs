using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LogMonitor : MonoBehaviour
{
    // Will be used to store a reference to the text mesh component
    private TextMesh textMesh;

    // Use this for initialization
    void Start()
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
        //Application.logMessageReceived -= LogMessage;
    }

    public void LogMessage(string message, string stackTrace, LogType type)
    {
        // Set the text 
        //textMesh.text = message;
    }

    void Update()
    {
		if (Input.GetKeyDown("1"))
		{
			Debug.Log("1");
		}
		if (Input.GetKeyDown("2"))
		{
			Debug.Log("2");
		}
		if (Input.GetKeyDown("3"))
		{
			Debug.Log("3");
		}
		if (Input.GetKeyDown("4"))
		{
			Debug.Log("4");
		}
		if (Input.GetKeyDown("5"))
		{
			Debug.Log("5");
		}
		if (Input.GetKeyDown("6"))
		{
			Debug.Log("6");
		}
		if (Input.GetKeyDown("7"))
		{
			Debug.Log("7");
		}
		if (Input.GetKeyDown("8"))
		{
			Debug.Log("8");
		}
		if (Input.GetKeyDown("9"))
		{
			Debug.Log("9");
		}
		if (Input.GetKeyDown("0"))
		{
			Debug.Log("0");
		}
		if (Input.GetKeyDown("a"))
		{
			Debug.Log("a");
		}
		if (Input.GetKeyDown("b"))
		{
			Debug.Log("b");
		}
		if (Input.GetKeyDown("c"))
		{
			Debug.Log("c");
		}
		if (Input.GetKeyDown("d"))
		{
			Debug.Log("d");
		}
		if (Input.GetKeyDown("e"))
		{
			Debug.Log("e");
		}
		if (Input.GetKeyDown("f"))
		{
			Debug.Log("f");
		}
		if (Input.GetKeyDown("g"))
		{
			Debug.Log("g");
		}
		if (Input.GetKeyDown("h"))
		{
			Debug.Log("h");
		}
		if (Input.GetKeyDown("i"))
		{
			Debug.Log("i");
		}
		if (Input.GetKeyDown("j"))
		{
			Debug.Log("j");
		}
		if (Input.GetKeyDown("k"))
		{
			Debug.Log("k");
		}
		if (Input.GetKeyDown("l"))
		{
			Debug.Log("l");
		}
		if (Input.GetKeyDown("m"))
		{
			Debug.Log("m");
		}
		if (Input.GetKeyDown("n"))
		{
			Debug.Log("n");
		}
		if (Input.GetKeyDown("o"))
		{
			Debug.Log("o");
		}
		if (Input.GetKeyDown("p"))
		{
			Debug.Log("p");
		}
		if (Input.GetKeyDown("q"))
		{
			Debug.Log("q");
		}
		if (Input.GetKeyDown("r"))
		{
			Debug.Log("r");
		}
		if (Input.GetKeyDown("s"))
		{
			Debug.Log("s");
		}
		if (Input.GetKeyDown("t"))
		{
			Debug.Log("t");
		}
		if (Input.GetKeyDown("u"))
		{
			Debug.Log("u");
		}
		if (Input.GetKeyDown("v"))
		{
			Debug.Log("v");
		}
		if (Input.GetKeyDown("w"))
		{
			Debug.Log("w");
		}
		if (Input.GetKeyDown("x"))
		{
			Debug.Log("x");
		}
		if (Input.GetKeyDown("y"))
		{
			Debug.Log("y");
		}
		if (Input.GetKeyDown("z"))
		{
			Debug.Log("z");
		}
		if (Input.GetKeyDown(KeyCode.Space))
		{
			Debug.Log("_SPACE_");
		}
		Debug.Log(Input.GetAxis("Horizontal") + " , " + Input.GetAxis("Vertical") + " , " + Input.GetAxis("Fire1") + " , " + Input.GetAxis("Jump"));
	}

}

