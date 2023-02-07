using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Photon.Pun;

public class GoalCounter : MonoBehaviour
{
    float mins;
    float secs;
    public TMP_Text timer;
    public GameObject gameoverpanel;
    public TMP_Text winner;
    public AudioSource sounds;
    // Start is called before the first frame update
    void Start()
    {
        mins = 3f;
        secs = 0f;
    }

    // Update is called once per frame
    void Update()
    {
        int num_players = PhotonNetwork.PlayerList.Length;
        if (num_players == 2)
        {
            secs -= Time.deltaTime;
            if (secs < 0)
            {
                mins -= 1f;
                secs = 60f;
                if (mins < 0f)
                {
                    gameoverpanel.SetActive(true);
                    if (PlayerPrefs.GetInt("RedScore") > PlayerPrefs.GetInt("BlueScore"))
                    {
                        winner.text = "Red Wins";
                        winner.color = Color.red;
                    }
                    else if (PlayerPrefs.GetInt("RedScore") < PlayerPrefs.GetInt("BlueScore"))
                    {
                        winner.text = "Blue Wins";
                        winner.color = Color.blue;
                    }
                    else
                    {
                        winner.text = "Tie";
                        winner.color = Color.black;
                    }

                }
            }
        }

        timer.text = "Time: " + ((int)mins).ToString("00") + ":" + ((int)secs).ToString("00");
    }

        void OnTriggerEnter2D(Collider2D collision)
        {
            if (collision.tag == "Ball")
            {
                if (this.name == "RedGoal")
                {
                    PlayerPrefs.SetInt("BlueScore", PlayerPrefs.GetInt("BlueScore") + 1);
                    Debug.Log("Goal for Blue");
                    sounds.Play();
                }
                if (this.name == "BlueGoal")
                {
                    PlayerPrefs.SetInt("RedScore", PlayerPrefs.GetInt("RedScore") + 1);
                    Debug.Log("Goal for Red");
                sounds.Play();
                }
            collision.gameObject.transform.position = new Vector2(-2.75f, -0.16f);
            collision.attachedRigidbody.velocity = Vector2.zero;
            }

        }
    }

