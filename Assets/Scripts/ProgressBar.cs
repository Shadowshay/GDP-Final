using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ProgressBar : MonoBehaviour
{
    Slider slider;
    public TMP_Text progressText;


    // Start is called before the first frame update
    void Start()
    {
        slider = GetComponent<Slider>();
        slider.minValue = 1000;
        slider.maxValue = 2000;
    }

    // Update is called once per frame
    void Update()
    {
        if (Code.Instance.cash <= 1000)
        {
            slider.value = slider.value = 1000;
        }
        else
        {
            slider.value = Code.Instance.cash;
        }
        progressText.text = "Goal: " + Code.Instance.cash + "/" + slider.maxValue;
    }
}
