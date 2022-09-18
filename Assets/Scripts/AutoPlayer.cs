using System.Collections;
using System.Collections.Generic;
using System.Timers;
using UnityEngine;

public class AutoPlayer : MonoBehaviour
{
    public AudioClip BG_NormalState;
    public AudioClip BG_Start;

    // Start is called before the first frame update
    private void Awake()
    {
        GetComponent<AudioSource>().clip = BG_Start;
        GetComponent<AudioSource>().Play();
    }
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Changemusic();
    }

    public void Changemusic()
    {
        double time = Time.time;
        bool changeFlage = true;

        if (time > 18 && changeFlage == true)
        {
            GetComponent<AudioSource>().Pause();
            GetComponent<AudioSource>().clip = BG_NormalState;
            GetComponent<AudioSource>().Play();
            changeFlage = false;
        }

    }
}
