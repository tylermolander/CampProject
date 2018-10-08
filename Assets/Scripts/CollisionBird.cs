using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Playables;

public class CollisionBird : MonoBehaviour
{
    public PlayableDirector timeline;
    public PlayableDirector stopTimeline;
    public GameObject bird;
    public bool istriggered = false; 

    void Start () 
    {        
        timeline = GetComponent<PlayableDirector>();        
        stopTimeline = bird.GetComponent<PlayableDirector>();

    }
    
    void OnTriggerEnter(Collider other)
    {
      Debug.Log("Collision");

        if  (istriggered == false)
        {
        timeline.Play();
        stopTimeline.Stop();
        }
    } 
    void OnTriggerExit( Collider other)
    {
        istriggered  = true;
    }
}
