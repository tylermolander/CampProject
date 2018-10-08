using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class SettingUpTentAnimation : MonoBehaviour 
{

    public GameObject setUpTentText;
    public GameObject sleepText;
    public PlayableDirector timeline;

    void Start () 
    { 	    
        timeline = GetComponent<PlayableDirector>();
    }
	
    void Update () 
    {
        if (Input.GetKey(KeyCode.Space))
        {
            Debug.Log("pressing space"); 
            Destroy(setUpTentText);
            timeline.Play();
            StartCoroutine(ActivateText());
        }
 
    }

    IEnumerator ActivateText()
    {
        yield return new WaitForSeconds(5);
        sleepText.SetActive(true);

    }


}




