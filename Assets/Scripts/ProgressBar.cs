using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ProgressBar : MonoBehaviour
{
    Slider slider;
    public TMP_Text progressText;
    public GameObject PopupWin;
    public GameObject PopupLose;
    public bool check = false;
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
        slider.value = Code.Instance.netWorth;
        progressText.text = "CASH: " + Code.Instance.cash + "\n NET WORTH GOAL: " + Code.Instance.netWorth + "/" + slider.maxValue;
        if (Code.Instance.netWorth >= slider.maxValue & check == false)
        {
            PopupWin.SetActive(true);
            check = true;
        }
        else if (Code.Instance.netWorth <= 0 & check == false)
        {
            PopupLose.SetActive(true);
            check = true;
        }
    }
}
