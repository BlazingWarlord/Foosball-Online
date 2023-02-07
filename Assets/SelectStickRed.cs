using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class SelectStickRed : MonoBehaviour
{
    public GameObject[] redsticks;
    public int total_index;
    public int index;
    PhotonView view;
    // Start is called before the first frame update
    void Start()
    {
        redsticks = GameObject.FindGameObjectsWithTag("RedStick");
        total_index = redsticks.Length;
        index = 0;
        MoveStick ms = redsticks[index].GetComponent<MoveStick>();
        //Debug.Log(ms.gameObject.name);
        ms.enabled = true;
        view = GetComponent<PhotonView>();
        
    }

    // Update is called once per frame
    void Update()
    {
        if (view.IsMine)
        {
            if (Input.GetKeyDown("x"))
            {
                MoveStick ms = redsticks[index].GetComponent<MoveStick>();
                ms.enabled = false;
                index += 1;
                if (index >= total_index)
                {
                    index = 0;
                }
                MoveStick ms1 = redsticks[index].GetComponent<MoveStick>();
                ms1.enabled = true;
                //Debug.Log(ms.gameObject.name);
            }

        }
    }
}
