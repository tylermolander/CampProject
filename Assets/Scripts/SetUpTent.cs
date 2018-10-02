using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Playables;

public class SetUpTent : MonoBehaviour
{
    public GameObject setUpTentText;


    void Start () 
    { 
    }
	
    void Update () 
    {
    }   
    

    void OnTriggerEnter(Collider other)
    {
        setUpTentText.SetActive(true);
        Debug.Log("TentCollision");

    }



}
