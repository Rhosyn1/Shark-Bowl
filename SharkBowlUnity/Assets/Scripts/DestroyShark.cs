﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DestroyShark : MonoBehaviour
{
    private UIBehaviour uiBehaviour2;


    void Start()
    {
        uiBehaviour2 = FindObjectOfType<UIBehaviour>();
    }

    void Update()
    {
        if (uiBehaviour2.slider.value == 1f)
        {
            Destroy(gameObject);
            SceneManager.LoadScene(1);
        }
    }
 
}
