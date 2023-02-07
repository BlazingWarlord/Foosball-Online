using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class SelectStickBlue : MonoBehaviour
{
    public GameObject[] redsticks;
    public int total_index;
    public int index;
    public PhotonView view;
    // Start is called before the first frame update
    void Start()
    {
        redsticks = GameObject.FindGameObjectsWithTag("BlueStick");
        total_index = redsticks.Length;
        index = 0;
        BlueMoveStick ms = redsticks[index].GetComponent<BlueMoveStick>();
        //Debug.Log(ms.gameObject.name);
        ms.enabled = true;
        //view = this.GetComponent<PhotonView>();
    }

    // Update is called once per frame
    void Update()
    {
        if(view.IsMine)
        {
            if (Input.GetKeyDown("x"))
            {
                BlueMoveStick ms = redsticks[index].GetComponent<BlueMoveStick>();
                ms.enabled = false;
                index += 1;
                if (index >= total_index)
                {
                    index = 0;
                }
                BlueMoveStick ms1 = redsticks[index].GetComponent<BlueMoveStick>();
                ms1.enabled = true;
                //Debug.Log(ms.gameObject.name);
            }

        }
    }
}
