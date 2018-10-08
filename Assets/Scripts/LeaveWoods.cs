using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Playables;

public class LeaveWoods : MonoBehaviour
{
    public PlayableDirector timeline;
    public GameObject leaveWoodsText;


    void Start () 
    { 
        timeline = GetComponent<PlayableDirector>();
    }
    
    void OnTriggerEnter(Collider other)
    {
        Debug.Log("TentCollision");
        timeline.Play();
        Destroy(leaveWoodsText);

    }



}
