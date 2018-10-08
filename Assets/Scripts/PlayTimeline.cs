﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class PlayTimeline : MonoBehaviour {

    public PlayableDirector timeline;

	// Use this for initialization
	void Start () 
	{
	    timeline = GetComponent<PlayableDirector>();
	}
	
	// Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.E))

        {
            timeline.Play();
        }
    }
}