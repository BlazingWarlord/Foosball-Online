using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartSetups : MonoBehaviour
{
    public GameObject pause_menu;
    public bool isenabled;
    // Start is called before the first frame update
    void Start()
    {
        
        isenabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            pause_menu.SetActive(!isenabled);
            isenabled = !isenabled;
        }
    }

    
}
