using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Playables;

public class LeaveWoods : MonoBehaviour
{
    public PlayableDirector finalTimeline;
    public GameObject leavewoodsText;



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
        Destroy(leavewoodsText);

    }



}
