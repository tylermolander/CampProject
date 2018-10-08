using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NewScene : MonoBehaviour {

	void Update () 
	{
	        //SceneManager.LoadScene("InTent");
	        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
	}
}
