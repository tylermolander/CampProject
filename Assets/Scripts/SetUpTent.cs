using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SetUpTent : MonoBehaviour
{
    public GameObject thing;

    void Start () 
    {
    }
	
    void Update () 
    {
		
    }
    void OnTriggerEnter(Collider other)
    {
        thing.SetActive(true);
        Debug.Log("TentCollision");
  }



}
