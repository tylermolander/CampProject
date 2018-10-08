using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class TakeDownTentScript : MonoBehaviour 
{

    public PlayableDirector timeline;
    public GameObject takeDownTentText;
    public GameObject leaveText;

    void Start () 
    { 
        Cursor.visible = false;
        timeline = GetComponent<PlayableDirector>();
    }
	
    void Update () 
    {
        if (Input.GetKey(KeyCode.Space))
        {
            Debug.Log("pressing space");      
            Destroy(takeDownTentText);
            timeline.Play();
            leaveText.SetActive(true);

        }
 
    }   


}




