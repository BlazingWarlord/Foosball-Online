using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using System.Linq;

public class MoveStick : MonoBehaviour
{
    Rigidbody2D rb;
    PhotonView view;
    public GameObject[] redmen;
    public Collider2D[] is_ball;
    public GameObject ball_go;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        view = GetComponent<PhotonView>();
        redmen = GameObject.FindGameObjectsWithTag("RedMan");
        ball_go = GameObject.FindGameObjectWithTag("Ball");
    }

    // Update is called once per frame
    void Update()
    {
        if (view.IsMine)
        {
            if (Input.GetKey("w"))
            {
                rb.velocity = new Vector2(0, 500f * Time.deltaTime);
            }
            else if (Input.GetKey("s"))
            {
                rb.velocity = new Vector2(0, -500f * Time.deltaTime);
            }
            else
            {
                rb.velocity = Vector2.zero;
            }

            if(Input.GetKeyDown(KeyCode.Space))
            {
                //view.TransferOwnership(PhotonNetwork.LocalPlayer);
                PhotonNetwork.SetMasterClient(PhotonNetwork.LocalPlayer);
                Debug.Log(view.ViewID.ToString() + PhotonNetwork.IsMasterClient);
                foreach (GameObject red in redmen)
                {
                    is_ball = Physics2D.OverlapCircleAll(red.transform.position, 1.5f);
                    if (is_ball.Length > 0)
                    {
                        foreach (Collider2D ball in is_ball)
                        {
                            if (ball.name == "Ball")
                            {
                                Rigidbody2D rbball = ball.GetComponent<Rigidbody2D>();
                                GameObject[] redmen_new = redmen.OrderBy((d) => (ball.transform.position - d.transform.position).sqrMagnitude).ToArray();
                                rbball.AddForce((ball.transform.position - redmen_new[0].transform.position).normalized * 300f * Time.deltaTime, ForceMode2D.Impulse);
                            }
                        }
                    }
                }
            }


        }
        
    }
    [PunRPC]
    void HitTheBall(GameObject ball)
    {
        
    }

}
