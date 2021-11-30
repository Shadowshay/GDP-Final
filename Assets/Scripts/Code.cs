using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Code : MonoBehaviour
{
    public static Code Instance { get; private set; }


    public int luckMultiplier = 11;

    public float cash = 1000;
    public float netWorth = 1000; 
    public int daysPassed = 0;
    public GameObject Date;

    // number of unit of stocks for each stock pattern
    public int goodStock = 0;
    public int badStock = 0;
    public int averageStock = 0;

    // value of stock 
    public float goodStockValue = 750;
    public float badStockValue = 1000;
    public float averageStockValue = 800;
    // value of stock past 10 days (Good Company)
    public List<float> StockValue  = new List<float>();
    public List<float> StockFluctuations = new List<float>();

    public GameObject companyAInfo;
    public GameObject companyBInfo;
    public GameObject companyCInfo;


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

    public void nextDay()
    {
        companyAInfo.SetActive(false);
        companyBInfo.SetActive(false);
        companyCInfo.SetActive(false);
        StockFluctuations.RemoveAt(0);
        StockValue.RemoveAt(0);
        calculateEarnings();
        daysPassed += 1;
        Date.GetComponent<TextMeshProUGUI>().SetText("DATE: " + daysPassed);


    }


    // function that updates networth;
    void calculateEarnings()
    {

        //here
        float change = RandomEvents.Instance.returnEffectOnStock();
        Debug.Log(change);

        if (Random.Range(1, 5) > 2)
        {
            float increase = Random.Range(1, luckMultiplier) / 100f * goodStockValue;
            increase = Mathf.Round(increase * 10f) / 10f;
            increase += change;
            Debug.Log(goodStockValue);
            goodStockValue += increase;
            Debug.Log(goodStockValue);
            goodStockValue = Mathf.Round(goodStockValue * 10f) / 10f;

            StockValue.Add(goodStockValue);
            StockFluctuations.Add(increase);
            netWorth += increase * goodStock ;
            netWorth = Mathf.Round(netWorth * 10f) / 10f;
            Debug.Log(netWorth);
        }
        else
        {
            float decrease = -Random.Range(1, luckMultiplier) / 100f * goodStockValue;
            decrease = Mathf.Round(decrease * 10f) / 10f;
            decrease += change;
            goodStockValue += decrease;
            goodStockValue = Mathf.Round(goodStockValue * 10f) / 10f;

            StockValue.Add(goodStockValue);
            StockFluctuations.Add(decrease);
            netWorth += (decrease) * goodStock;
            netWorth = Mathf.Round(netWorth * 10f) / 10f;
            Debug.Log(netWorth);
        }


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
