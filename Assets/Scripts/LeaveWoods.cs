using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Playables;

public class LeaveWoods : MonoBehaviour
{
    public PlayableDirector finalTimeline;


    void Start () 
    { 
        finalTimeline = GetComponent<PlayableDirector>();

    }
	
    void Update () 
    {
    }   
    

    void OnTriggerEnter(Collider other)
    {
        Debug.Log("TentCollision");
        finalTimeline.Play();

    }



}
