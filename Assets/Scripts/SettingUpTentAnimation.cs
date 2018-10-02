using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class SettingUpTentAnimation : MonoBehaviour 
{

    public PlayableDirector timelineS;
    public GameObject setUpTentText;
    public GameObject sleepText;
    public float time = 3;

    void Start () 
    { 
        timelineS = GetComponent<PlayableDirector>();
    }
	
    void Update () 
    {
        if (Input.GetKey(KeyCode.Space))
        {
            Debug.Log("pressing space");      
            Destroy(setUpTentText);
            timelineS.Play();
            sleepText.SetActive(true);

        }
 
    }   


}




