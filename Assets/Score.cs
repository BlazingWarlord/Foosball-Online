using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using TMPro;

public class Score : MonoBehaviour
{
    public TMP_Text redscore;
    public TMP_Text bluescore;
    public string name1;
    public string name2;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        redscore.text = "Red: " + PlayerPrefs.GetInt("RedScore").ToString();
        bluescore.text = PlayerPrefs.GetInt("BlueScore").ToString() + " :Blue";
    }
}
