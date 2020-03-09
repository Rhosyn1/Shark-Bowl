using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoldfishBehaviour : MonoBehaviour
{
    private UIBehaviour uiBehaviour;

    [SerializeField]
    private float fillValue = 0.15f;

    [SerializeField]
    private float destroyTime = 2f;

    // Start is called before the first frame update
    void Start()
    {
        uiBehaviour = FindObjectOfType<UIBehaviour>();
        Invoke("DestroyGoldfish", destroyTime);
    }
    private void DestroyGoldfish()
    {
        uiBehaviour.UpdateSlider(fillValue);
        Destroy(gameObject);
    }
}
