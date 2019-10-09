using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using QTMRealTimeSDK;
using QTMRealTimeSDK.Data;
using QualisysRealTime.Unity;

// This class automatically connects to the Qualisys server on startup
public class QTMConnector : MonoBehaviour
{
    public string host; // The ipaddress of the host server, make sure you set this in the editor
    private DiscoveryResponse server;
    private bool foundServer = false;
    private RTClient rtClient;

    void Start()
    {
        // Get the global RTClient object from the Qualisys system
        rtClient = RTClient.GetInstance();

        // Loop through discovered servers to find one that matches our needs
        foreach (var discoveryResponse in rtClient.GetServers())
        {
            // Check if the response has the right IP address
            if (discoveryResponse.IpAddress == host)
            {
                Debug.Log("Desired Host Found");
                server = discoveryResponse;
                foundServer = true;
            }
        }

        // If a server is found at the correct host, connect to the server
        if (foundServer)
        {
            rtClient.Connect(server, 4545, true, true, false, false, false);
        }
    }
}