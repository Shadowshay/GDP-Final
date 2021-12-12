using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Code : MonoBehaviour
{
    public static Code Instance { get; private set; }


    public int luckMultiplier = 10;

    public float cash = 1000;
    public float netWorth = 1000; 
    public int daysPassed = 0;
    public GameObject Date;

    // number of unit of stocks for each stock pattern
    public int goodStock = 0;
    public int badStock = 0;
    public int averageStock = 0;

    // value of stock 
    public float goodStockValue = 200;
    public float badStockValue = 400;
    public float averageStockValue = 300;
    // value of stock past 10 days (Good Company)
    public List<float> StockValue  = new List<float>();
    public List<float> StockFluctuations = new List<float>();

    // value of stock past 10 days (Average Company)
    public List<float> StockValue1 = new List<float>();
    public List<float> StockFluctuations1 = new List<float>();

    // value of stock past 10 days (Bad Company)
    public List<float> StockValue2 = new List<float>();
    public List<float> StockFluctuations2 = new List<float>();

    public GameObject companyAInfo;
    public GameObject companyBInfo;
    public GameObject companyCInfo;
    public GameObject Helper;



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

        if (StockFluctuations.Count != 0)
        {
            StockFluctuations.RemoveAt(0);
            StockValue.RemoveAt(0);
        }
        if (StockFluctuations1.Count != 0)
        {
            StockFluctuations1.RemoveAt(0);
            StockValue1.RemoveAt(0);
        }
        if (StockFluctuations2.Count != 0)
        {
            StockFluctuations2.RemoveAt(0);
            StockValue2.RemoveAt(0);
        }


        //HelperSystem();


        calculateEarnings();
        daysPassed += 1;
        Date.GetComponent<TextMeshProUGUI>().SetText("DATE: " + daysPassed);
        
        if(netWorth >= 1000)
        {
            Achievement.Instance.Stonks = true;
            Achievement.Instance.gameObject.transform.GetChild(3).gameObject.SetActive(false);
            Achievement.Instance.gameObject.transform.GetChild(4).gameObject.SetActive(true);
        }
        Notifications.Instance.OpenNotif();
        Notifications.Instance.CheckAchievements();
    }


    public void HelperSystem()
    {
        float xPos = Random.Range(-7f, 6f);
        float yPos = Random.Range(2.45f, -2.3f);
        Vector2 position = new Vector2(xPos, yPos);
        float i = Random.Range(1, 3);
        if (i == 1)
        {
            Helper.SetActive(true);
            Helper.transform.position = position;
        }
        else
        {
            Helper.SetActive(false);
        }
    }


    // function that updates networth;
    public void calculateEarnings()
    {

        //here
        float change = RandomEvents.Instance.returnEffectOnStock();
        Debug.Log(RandomEvents.Instance.eventID);


            if (Random.Range(1, 6) > 2)
            {
                float increase = Random.Range(1, luckMultiplier + 1) / 100f * goodStockValue;
                increase = Mathf.Round(increase * 10f) / 10f;
                increase += change;
                goodStockValue += increase;
                goodStockValue = Mathf.Round(goodStockValue * 10f) / 10f;

                StockValue.Add(goodStockValue);
                StockFluctuations.Add(increase);
                netWorth += increase * goodStock;
                netWorth = Mathf.Round(netWorth * 10f) / 10f;
            }

            else
            {
                float decrease = -Random.Range(1, luckMultiplier + 1) / 100f * goodStockValue;
                decrease = Mathf.Round(decrease * 10f) / 10f;
                decrease += change;
                goodStockValue += decrease;
                goodStockValue = Mathf.Round(goodStockValue * 10f) / 10f;

                StockValue.Add(goodStockValue);
                StockFluctuations.Add(decrease);
                netWorth += (decrease) * goodStock;
                netWorth = Mathf.Round(netWorth * 10f) / 10f;
            }


            if (Random.Range(1, 3) > 1)
            {
                float increase = Random.Range(1, luckMultiplier + 1) / 100f * averageStockValue;
                increase = Mathf.Round(increase * 10f) / 10f;
                increase += change;
                averageStockValue += increase;
                averageStockValue = Mathf.Round(averageStockValue * 10f) / 10f;

                StockValue1.Add(averageStockValue);
                StockFluctuations1.Add(increase);
                netWorth += increase * averageStock;
                netWorth = Mathf.Round(netWorth * 10f) / 10f;
        }
            else
            {
                float decrease = -Random.Range(1, luckMultiplier + 1) / 100f * averageStockValue;
                decrease = Mathf.Round(decrease * 10f) / 10f;
                decrease += change;
                averageStockValue += decrease;
                averageStockValue = Mathf.Round(averageStockValue * 10f) / 10f;

                StockValue1.Add(averageStockValue);
                StockFluctuations1.Add(decrease);
                netWorth += (decrease) * averageStock;
                netWorth = Mathf.Round(netWorth * 10f) / 10f;
            }

        if (Random.Range(1, 6) > 3)
        {
            float increase = Random.Range(1, luckMultiplier + 1) / 100f * badStockValue;
            increase = Mathf.Round(increase * 10f) / 10f;
            increase += change;
            badStockValue += increase;
            badStockValue = Mathf.Round(badStockValue * 10f) / 10f;

            StockValue2.Add(badStockValue);
            StockFluctuations2.Add(increase);
            netWorth += increase * badStock;
            netWorth = Mathf.Round(netWorth * 10f) / 10f;

        }

        else
        {
            float decrease = -Random.Range(1, luckMultiplier + 1) / 100f * badStockValue;
            decrease = Mathf.Round(decrease * 10f) / 10f;
            decrease += change;
            badStockValue += decrease;
            badStockValue = Mathf.Round(badStockValue * 10f) / 10f;

            StockValue2.Add(badStockValue);
            StockFluctuations2.Add(decrease);
            netWorth += (decrease) * badStock;
            netWorth = Mathf.Round(netWorth * 10f) / 10f;
        }
    }


}
