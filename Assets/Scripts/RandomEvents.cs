using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomEvents : MonoBehaviour
{

    public Code code;
    public RandomEventAsset RandomEventAsset;
    public GameObject Notification;

    // Start is called before the first frame update
    void Start()
    {
        if (Random.Range(1, 100) == RandomEventAsset.EventID)
        {
            if (RandomEventAsset.EffectOnStock < 0)
            {
                code.averageStock -= RandomEventAsset.EffectOnStock;
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
