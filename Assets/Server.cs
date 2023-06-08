//THIS CONTAINS THE FUNCTIONS TO INTERACT WITH THE SERVER

//Imports libraries
using System;
using UnityEngine;
using UnityEngine.UI;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Net;
using System.Net.Sockets;

public class Server : MonoBehaviour// : Form
{
    // Main Variables
    public static int port = 7715; //Port number of server
    public static string message; //Message to send
    public static int byteCount; //Raw bytes to send
    public static NetworkStream stream; //Link stream
    public static byte[] sendData; //Raw data to send
    public static TcpClient client; //TCP client variable

    

    //toolStripButton1 -- Open Connection
    public static void open_connection()//object sender, EventArgs e)
    {
        
        
        //Attempts to make connection
        string text = "192.168.0.102"; 

        print(text);

        try
        {
            client = new TcpClient(text, port);
            //Adds debug to list box and shows message box
            print("Connection made with " + text);
        }
        catch (System.Net.Sockets.SocketException)
        {
            print("Connection failed");
        }
        
        
    }

    //toolStripButton2 -- Send
    public static void send(string message)//object sender, EventArgs e)
    {
        try
        {
            byteCount = Encoding.ASCII.GetByteCount(message); //Measures bytes required to send ASCII data
            sendData = new byte[byteCount]; //Prepares variable size for required data
            sendData = Encoding.ASCII.GetBytes(message); //Sets the sendData variable to the actual binary data (from the ASCII)
            stream = client.GetStream(); //Opens up the network stream
            stream.Write(sendData, 0, sendData.Length); //Transmits data onto the stream

            print("Sent data " + message);
        }
        catch (System.NullReferenceException) //Error if socket not open
        {
            //Adds debug to list box and shows message box

            print("failed to send data");

            // MessageBox.Show("Connection not installised");
            // listBox1.Items.Add("Failed to send data");
        }
    }

    //toolStripButton3 -- Close Connection
    public static void close_connection()//object sender, EventArgs e)
    {
        stream.Close(); //Closes data stream
        client.Close(); //Closes socket

        print("connection terminated");

        // listBox1.Items.Add("Connection terminated"); //Adds debug message to list box
    }

}
