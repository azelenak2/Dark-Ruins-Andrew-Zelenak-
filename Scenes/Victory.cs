﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Victory : MonoBehaviour
{ 

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {

            SceneManager.LoadScene(1);
        }

        if (Input.GetKeyDown(KeyCode.M))
        {

            SceneManager.LoadScene(0);
        }
    }
}
