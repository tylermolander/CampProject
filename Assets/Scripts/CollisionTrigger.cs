using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Playables;

public class CollisionTrigger : MonoBehaviour
{
    public GameObject collisionText;
    
    void Start () 
    { 
    }
    
    void OnTriggerEnter(Collider other)
    {
        Debug.Log("Collision");
        collisionText.SetActive(true);
    }
}
