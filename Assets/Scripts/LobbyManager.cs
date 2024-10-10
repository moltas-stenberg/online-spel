using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using Photon.Realtime;

public class LobbyManager : MonoBehaviourPunCallbacks
{
    public void JoinGame()
    {
        PhotonNetwork.JoinRandomRoom();
        Debug.Log("trying to join room...");
    }

    public override void OnJoinRandomFailed(short returnCode, string message)
    {
        Debug.Log("there are no rooms, idjit");
        CreateRoom();
    }

    void CreateRoom()
    {
        Debug.Log("Creating room");
        int num = Random.Range(0, 20000000);
        RoomOptions options = new RoomOptions()
        {
            IsVisible = true,
            IsOpen = true,
            MaxPlayers = 20,
        };
        PhotonNetwork.CreateRoom("Room" + num, options);
        Debug.Log("Created room " + num);
    }
}
