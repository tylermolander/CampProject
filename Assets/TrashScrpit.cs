using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrashScrpit : MonoBehaviour {

   
    Animator anim;
    public GameObject charachter;
    public GameObject anchor;
    public bool pickingUp = false;
    public bool isWalkingTowards = false;

	void Start ()
	{
	    anim = charachter.GetComponent<Animator>();
	}

	void Update () 
	{
	    if (isWalkingTowards)
	    {
	        AutoWalkTowards();
	    }

	}

    //have a coroutine that waits a few seconds before returning control of animator and allowing isWalking, etc.

    void OnMouseDown()
    {
        if (!pickingUp)
        {
            anim.SetBool("isWalking", true);
            isWalkingTowards = true;
            FPSInput.controlledBy = this.gameObject; 
        }

        else
        {
            isWalkingTowards = false;
            FPSInput.controlledBy = null; 
        }
    }

    void AutoWalkTowards()
    {
        Vector3 targetDir;
        targetDir = new Vector3(anchor.transform.position.x - charachter.transform.position.x,
                                0f,
                                anchor.transform.position.z - charachter.transform.position.z);

        Quaternion rot = Quaternion.LookRotation(targetDir);
        charachter.transform.rotation = Quaternion.Slerp(charachter.transform.rotation, rot, 0.05f);
        charachter.transform.Translate(Vector3.forward * 0.3f);

        if (Vector3.Distance (charachter.transform.position, anchor.transform.position) < 10)
        {
            anim.SetBool("pickUp", true);
            anim.SetBool("isWalking", false);

            charachter.transform.rotation = anchor.transform.rotation;

            isWalkingTowards = false;
            pickingUp = true;

            //Destroy(gameObject);
        }

    }

}
