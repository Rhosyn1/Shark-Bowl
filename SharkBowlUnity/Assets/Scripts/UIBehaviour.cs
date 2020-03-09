using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIBehaviour : MonoBehaviour
{
    public Slider slider;
    [SerializeField]
    private Image sliderImage;
    
    // Start is called before the first frame update
    void Start()
    {
        slider = GetComponentInChildren<Slider>();
    }

    // Update is called once per frame
    void Update()
    {
        if (slider.value >= 0.7f)
        {
            sliderImage.color = new Color(255f, 0f, 0f);
        }
        if (slider.value < 0.7f)
        {
            sliderImage.color = new Color(0f, 255f, 0f);
        }
    }

    public void UpdateSlider(float v)
    {
        slider.value += v;
    } 

    public void DecreaseSlider(float f)
    {
        slider.value -= f;
    }
}
