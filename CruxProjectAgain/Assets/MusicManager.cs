using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicManager : MonoBehaviour
{
    public AudioSource aus;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        DontDestroyOnLoad(aus);
    }

    public void mute()
    {
        aus.mute = !aus.mute;
    }
}
