using System.Collections;
using System.Collections.Generic;
using System;
using System.Text; 
using System.Net; 
using System.Net.Sockets; 
using System.Threading;
using System.Linq;
using UnityEngine;

public class Server : MonoBehaviour
{
    public int outPort = 8000; 
    public int inPort = 8001;

    private static UdpClient client; 
    private static IPEndPoint remoteEndpoint; 
    private static Thread recieveThread; 

    private void Awake()
    {
        remoteEndpoint = new IPEndPoint(IPAddress.Any, outPort);
        client = new UdpClient(inPort);
        client.BeginReceive(RecieveData, null);
    }

    private void RecieveData(IAsyncResult _result)
    {
        
    }

    
}
