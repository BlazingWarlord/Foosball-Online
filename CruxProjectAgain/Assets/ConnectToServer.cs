using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class ConnectToServer : MonoBehaviourPunCallbacks
{
    public TMP_InputField name_text;
    public TMP_Text button_text;
    public TMP_Text conn;
    // Start is called before the first frame update
    public void Connect()
    {

        conn.text = "Connecting...";
        PhotonNetwork.ConnectUsingSettings();
    }

    // Update is called once per frame
    public override void OnConnectedToMaster()
    {
        PhotonNetwork.JoinLobby();
    }
    public override void OnJoinedLobby()
    {
        SceneManager.LoadScene("lobby");
    }

    public void OnDisconnectedFromServer()
    {
        conn.text = "Can't Connect";
    }

    public void Quit()
    {
        Application.Quit();
    }
}
