using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager: MonoBehaviour {
    public int maxMessages = 25;
    public GameObject chatPanel, textObject;
    public InputField chatBox;

    [SerializeField]
    public List<Message> messageList = new List<Message>();
    public GameMessenger messenger;
	// Use this for initialization
	void Start () {
        messenger = new GameMessenger();
        messenger.sendtext("asdf");
	}
	
	// Update is called once per frame
	void Update () {
        if (!chatBox.isFocused) {
            
        }
        if (Input.GetKeyDown(KeyCode.Space)) {
            SendMessageToChat("You just pressed space bar");
            Debug.Log("Space");
        }
	}

    public void SendMessageToChat(string text) {
       if(messageList.Count >= maxMessages) {
            Destroy(messageList[0].textObject.gameObject);
            messageList.Remove(messageList[0]);
        }

        Message newMessage = new Message(text);

        //newMessage.text = text;

        GameObject newText = Instantiate(textObject, chatPanel.transform);

        newMessage.textObject = newText.GetComponent<Text>();

        newMessage.textObject.text = newMessage.text;

        messageList.Add(newMessage);
    }
}

[System.Serializable]
public class Message {
    public string text;
    public Text textObject;
    public Message(string s) {
        text = s;
    }
}