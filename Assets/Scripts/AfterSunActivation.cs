﻿using UnityEngine;
using UnityEngine.SceneManagement;
 
public class AfterSunActivation : MonoBehaviour
{
    void OnEnable()
    {
        // Only specifying the sceneName or sceneBuildIndex will load the Scene with the Single mode
        SceneManager.LoadScene("TakeDownTent", LoadSceneMode.Single);
    }
}
