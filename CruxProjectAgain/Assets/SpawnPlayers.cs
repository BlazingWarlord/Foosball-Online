using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class SpawnPlayers : MonoBehaviour
{
    public GameObject RedStick;
    public GameObject BlueStick;
    public GameObject Ball;
    public float redX = -1.41f;
    public float redY = 0.1f;
    public float blueX = 1.63f;
    public float blueY = -0.1f;
    
    // Start is called before the first frame update
    void Start()
    {
        int num_players = PhotonNetwork.PlayerList.Length;

        if (PlayerPrefs.GetInt("RedSpawned") == 0)
        {
            
            //PhotonNetwork.Instantiate(Ball.name, new Vector2(0,0), Quaternion.identity);
        }

        if (num_players == 1)
        {
            
            
            PhotonNetwork.Instantiate(RedStick.name, new Vector2(redX, redY), Quaternion.identity);
            //PhotonNetwork.Instantiate("Ball", new Vector2(-2.75f, -0.16f), Quaternion.Euler(0, 0, 180));

        }
        else if (num_players == 2)
        {
            PhotonNetwork.Instantiate(BlueStick.name, new Vector2(blueX,blueY), Quaternion.Euler(0, 0, 180));
            

        }
        else
        {
            PhotonNetwork.LeaveRoom();
        }

        
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
