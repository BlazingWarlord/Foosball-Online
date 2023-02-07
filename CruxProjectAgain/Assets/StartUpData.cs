using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartUpData : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        PlayerPrefs.SetInt("RedScore", 0);
        PlayerPrefs.SetInt("BlueScore", 0);
        PlayerPrefs.SetInt("RedSpawned", 0);
    }
}
