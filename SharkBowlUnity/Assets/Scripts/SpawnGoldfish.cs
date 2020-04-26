using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using System.IO.Ports;


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

   /* SerialPort sp = new SerialPort("COM5", 9600);
    private float scaleValue = 0f;
    private float lastStableWeight = 0f;
    private float lastWeight = 0f;
    private int stableCount = 0;
    private float offsetWeight = 0.1f;
    private float fishWeight = 0.2f; */
    void Start()
    {
        uiBehaviour1 = FindObjectOfType<UIBehaviour>();
        //decrease the hunger meter
        InvokeRepeating("NoGoldfishSpawned", timeToDecrease, timeToDecrease);
       /* sp.Open();
        sp.ReadTimeout = 1000;
        //read value from arduino 
        scaleValue = float.Parse(sp.ReadLine(), System.Globalization.NumberStyles.Float);
        lastStableWeight = scaleValue;
        lastWeight = scaleValue;*/
    }

    // Update is called once per frame
    void Update()
    {
        //trying to get a stable weight so that we can check the change in weight
       /* scaleValue = float.Parse(sp.ReadLine(), System.Globalization.NumberStyles.Float);
        if (Mathf.Abs(scaleValue - lastWeight) <= offsetWeight)
        {
            stableCount++;
        }
        else
        {
            stableCount = 0;
        }

        if (stableCount >= 30)
        {
            //adding fish if the change in weight is large enough
            if (Mathf.Abs(scaleValue - lastStableWeight) >= fishWeight)
            {
                Instantiate(goldfishPrefab, new Vector3(Random.Range(xMin, xMax), Random.Range(yMin, yMax), 0f), Quaternion.identity);
                lastStableWeight = scaleValue;
            }
        }*/
        if (Input.GetButtonDown("Jump"))
        {
            Instantiate(goldfishPrefab, new Vector3(Random.Range(xMin, xMax), Random.Range(yMin, yMax), 0f), Quaternion.identity);
        }

        //lastWeight = scaleValue;
    }

    private void NoGoldfishSpawned()
    {
        uiBehaviour1.DecreaseSlider(decreaseValue);
    }
}
