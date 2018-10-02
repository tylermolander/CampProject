using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class InsideTimeline : MonoBehaviour {

    public PlayableDirector timelineL;


    // Use this for initialization
    void Start ()
    {
        timelineL = GetComponent<PlayableDirector>();
    }
	
    // Update is called once per frame
    void Update () 
    {
        {
            if(Input.GetKeyUp(KeyCode.F))
            {
                timelineL.Play();
            }
        }
    }
}