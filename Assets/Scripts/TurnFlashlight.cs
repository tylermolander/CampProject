using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class TurnFlashlight : MonoBehaviour
{

    public Light flashlight;


	// Use this for initialization
	void Start ()
	{
	    Cursor.visible = false;
	    flashlight = GetComponent<Light>();        
    }
	
	// Update is called once per frame
	void Update () 
	{
	    {
	        if(Input.GetKeyUp(KeyCode.F))
	        {
	            flashlight.enabled = !flashlight.enabled;
            }
	    }
	}
}
