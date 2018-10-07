using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class TakeDownTentScript : MonoBehaviour 
{

    public PlayableDirector takeDownTimeline;
    public GameObject takeDownTentText;
    public GameObject leaveText;
    public float time = 3;

    void Start () 
    { 
        Cursor.visible = false;
        takeDownTimeline = GetComponent<PlayableDirector>();
    }
	
    void Update () 
    {
        if (Input.GetKey(KeyCode.Space))
        {
            Debug.Log("pressing space");      
            Destroy(takeDownTentText);
            takeDownTimeline.Play();
            leaveText.SetActive(true);

        }
 
    }   


}




