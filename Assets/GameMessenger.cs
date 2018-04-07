using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Net.Sockets;
using System.Threading;

public class GameMessenger : MonoBehaviour {

    //List<Message> messagelist = new List<Message>();
    // TcpClient client;
    // NetworkStream nwStream;
    // Thread receiverThread;

    //public Messenger() {
    //    // createConnection("127.0.0.1", 8080);
    //    // Thread receiverThread = new Thread(new ThreadStart(MessageReceiver));
    //    //receiverThread.start();
    //}

    // public bool endConnection() {
    //   receiverThread.Abort();
    //   client.Close();
    // }

    public void sendtext(string text) {
        // byte[] bytesToSend = ASCIIEncoding.ASCII.GetBytes(text);
        // nwStream.Write(bytesToSend, 0, bytesToSend.Length);
        Message m = new Message(text);
        GameObject.FindGameObjectWithTag("GameManager").GetComponent<GameManager>().messageList.Add(m); 
        //messagelist.Add(m);
        Debug.Log("in messenger.cs, sendtext()" + text);
    }

    //private bool createConnection(string IP, int PortNum) {
    //    client = new TcpClient(IP, PORTNum);
    //    nwStream = client.GetStream();
    //    return true;
    //}

    //private void MessageReceiver() {
    //    while (true) {
    //        byte[] bytesToRead = new byte[client.ReceiveBufferSize];
    //        int bytesRead = nwStream.Read(bytesToRead, 0, client.ReceiveBufferSize);
    //        Message m = new Message(Encoding.ASCII.GetString(bytesToRead, 0, bytesRead))
    //      messagelist.Add(m);
    //    }
    //}
}

//public class Message() {
//  public string text;
//  public Message(string s) {
//    text = s;
//  }
//}
