using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SetUpTent : MonoBehaviour
{
    public GameObject setUpTentText;

    void Start () 
    { 

    }
	
    void Update () 
    {
        if (Input.GetKey(KeyCode.Space))
        {
            //SetUpTentAnimation
        }
    }
    void OnTriggerEnter(Collider other)
    {
        setUpTentText.SetActive(true);
        Debug.Log("TentCollision");
    }



}
