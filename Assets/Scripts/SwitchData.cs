using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchData : MonoBehaviour
{
    [SerializeField] private GameObject WindowGraph;
    [SerializeField] private GameObject Analytics;

    public void SwitchDataType()
    {
        if(WindowGraph.activeSelf == true)
        {
            WindowGraph.SetActive(false);
        }
        else
        {
            WindowGraph.SetActive(true);
        }

        if (Analytics.activeSelf == true)
        {
            Analytics.SetActive(false);
        }
        else
        {
            Analytics.SetActive(true);
        }
    }
}
