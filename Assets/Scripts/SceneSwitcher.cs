﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwitcher : MonoBehaviour {

    void Start()
    {
        Cursor.visible = true;
    }
    public void GotoMainScene()
    {
        SceneManager.LoadScene("SetUpTent");
    }
}
