﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class FlashlightTimeline : MonoBehaviour {

    public PlayableDirector timeline;
    public GameObject flashlightText;



    // Use this for initialization
    void Start ()
    {
        timeline = GetComponent<PlayableDirector>();
    }
	
    // Update is called once per frame
    void Update () 
    {
        {
            if(Input.GetKeyUp(KeyCode.F))
            {
                timeline.Play();
                Destroy(flashlightText);

            }
        }
    }
}