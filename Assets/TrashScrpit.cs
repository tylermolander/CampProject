using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrashScrpit : MonoBehaviour {

    //public bool hasTrash;
    //public GameObject trash;
    Animator anim;
    public GameObject charachter;

	void Start ()
	{
	    anim = charachter.GetComponent<Animator>();
	}
	
    //maybe add a "remaining trash" counter
    //loose the game: "You forgot to take out your trash!!!"

	void Update () 
	{
	}

    void OnMouseDown()
    {
        anim.SetTrigger("pickUp");
        //destrory trash

        //walk to trash animation
    }
}
