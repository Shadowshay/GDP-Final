using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomEvents : MonoBehaviour
{
    public static RandomEvents Instance { get; private set; }

    public RandomEventAsset RandomEventAsset;
    public GameObject Notification;


    // singleton that other classes can take variables from
    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    //public float returnEffectOnStockPrice()
    //{
    //    if (Random.Range(1, 100) == RandomEventAsset.EventID)
    //    {
    //        if (RandomEventAsset.EffectOnStock < 0)
    //        {
    //            Code.Instance.goodStockValue -= RandomEventAsset.EffectOnStock;
    //        }
    //    }
    //}

    // Update is called once per frame
    void Update()
    {
        
    }
}
