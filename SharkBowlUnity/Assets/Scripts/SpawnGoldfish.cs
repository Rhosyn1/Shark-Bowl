﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnGoldfish : MonoBehaviour
{
    [SerializeField]
    private GameObject goldfishPrefab;

    private UIBehaviour uiBehaviour1;

    private float decreaseValue = 0.05f;
    private float timeToDecrease = 1f;

    private float xMin = -8f;
    private float xMax = 0f;
    private float yMin = -4f;
    private float yMax = 4f;

    void Start()
    {
        uiBehaviour1 = FindObjectOfType<UIBehaviour>();
        InvokeRepeating("NoGoldfishSpawned", timeToDecrease, timeToDecrease);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Jump"))
        {
            Instantiate(goldfishPrefab, new Vector3(Random.Range(xMin, xMax), Random.Range(yMin, yMax), 0f), Quaternion.identity);
        }
    }

    private void NoGoldfishSpawned()
    {
        uiBehaviour1.DecreaseSlider(decreaseValue);
    }
}
