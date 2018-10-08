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
        timeline = GetComponent<PlayableDirector>();        
        StartCoroutine(ActivateTentText());

    }
	
    void Update () 
    {
        if (Input.GetKey(KeyCode.Space))
        {
            Debug.Log("pressing space");      
            Destroy(takeDownTentText);
            timeline.Play();
            StartCoroutine(ActivateLeaveText());
        }
    }   

    IEnumerator ActivateTentText()
    {
        yield return new WaitForSeconds(2);
        takeDownTentText.SetActive(true);
    }

    IEnumerator ActivateLeaveText()
    {
        yield return new WaitForSeconds(4);
        leaveText.SetActive(true);
    }

}




