using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrashScrpit : MonoBehaviour {

    public bool hasTrash;
    public GameObject trash;

	void Start () 
    {
		
	}
	
    //maybe add a "remaining trash" counter
	void Update () 
	{
		//picking up trash > trashobject destroyed, hasTrash is true
        //if false:
            //loose the game: "You forgot to take out your trash!!!"


	}
}
