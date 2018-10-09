using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrashScrpit : MonoBehaviour {

   
    Animator anim;
    public GameObject charachter;
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
        targetDir = new Vector3(transform.position.x - charachter.transform.position.x,
                                0f,
                                transform.position.z - charachter.transform.position.z);

        Quaternion rot = Quaternion.LookRotation(targetDir);
        charachter.transform.rotation = Quaternion.Slerp(charachter.transform.rotation, rot, 0.05f);
        charachter.transform.Translate(Vector3.forward * 0.1f);

        if (Vector3.Distance (charachter.transform.position, this.transform.position) < 0.6)
        {
            anim.SetTrigger("pickUp");

            charachter.transform.rotation = this.transform.rotation;

            isWalkingTowards = false;
            pickingUp = true;
        }

    }

}
