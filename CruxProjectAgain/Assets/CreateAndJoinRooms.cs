using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Photon.Pun;

public class CreateAndJoinRooms : MonoBehaviourPunCallbacks
{
    public InputField create;
    public InputField join;
    // Start is called before the first frame update
    public void CreateRoom()
    {
        PhotonNetwork.CreateRoom(create.text);
       

    }
    public override void OnCreatedRoom()
    {
        base.OnCreatedRoom();
        ExitGames.Client.Photon.Hashtable roomProps = new ExitGames.Client.Photon.Hashtable();
        roomProps["RedSpawned"] = 1;
        PhotonNetwork.CurrentRoom.SetCustomProperties(roomProps);
    }

    // Update is called once per frame
    public void JoinRoom()
    {
        PhotonNetwork.JoinRoom(join.text);
        

    }
    public override void OnJoinedRoom()
    {
        PhotonNetwork.LoadLevel("MainGameScene");
    }
    public void Leave()
    {
        PhotonNetwork.LeaveRoom();
    }
    public override void OnLeftRoom()
    {
        PhotonNetwork.LoadLevel("lobby");
    }

}
