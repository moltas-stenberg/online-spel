using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using UnityEngine.UI;

public class ServerManager : MonoBehaviourPunCallbacks 
{
    [SerializeField] Button startButton;
    // Start is called before the first frame update
    void Start()
    {
        startButton.interactable = false;
        PhotonNetwork.ConnectUsingSettings();
        Debug.Log("connecting...");
    }

    public override void OnConnectedToMaster()
    {
        Debug.Log("Connected! Server: " + PhotonNetwork.CloudRegion);
        startButton.interactable = true;
        PhotonNetwork.AutomaticallySyncScene = true;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
