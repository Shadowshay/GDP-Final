using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Code : MonoBehaviour
{
    public static Code Instance { get; private set; }

    public int cash = 1000;
    public int netWorth = 1000; 
    public int daysPassed = 0;
    public TMPro.TextMeshPro Date ;
    public Text cashText;
    public int unitsOwned = 0;

    // number of unit of stocks for each stock pattern
    public int goodStock = 0;
    public int badStock = 0;
    public int averageStock = 0;

    // value of stock 
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
    public float goodStockValue = 0;
    public float badStockValue = 0;
    public float averageStockValue = 0;
=======
    public int goodStockValue = 0;
    public int badStockValue = 0;
    public int averageStockValue = 0;
>>>>>>> parent of af54c8c (Analytics Table)
=======
    public int goodStockValue = 0;
    public int badStockValue = 0;
    public int averageStockValue = 0;
>>>>>>> parent of af54c8c (Analytics Table)
=======
    public int goodStockValue = 0;
    public int badStockValue = 0;
    public int averageStockValue = 0;
>>>>>>> parent of af54c8c (Analytics Table)
=======
    public int goodStockValue = 0;
    public int badStockValue = 0;
    public int averageStockValue = 0;
>>>>>>> parent of af54c8c (Analytics Table)

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

    void nextDay()
    {
        calculateEarnings();
        daysPassed += 1;
        Date.SetText("Days Passed: " + daysPassed);
    }


    // function that updates networth;
    void calculateEarnings()
    {
        if (Random.Range(-1, 2) > 0)
        {
            int increase = Random.Range(1, 10) * 1 / 100 * goodStockValue;
            goodStockValue += increase;
            netWorth += increase * goodStock ;
        }
        else
        {
            int decrease = - Random.Range(1, 10) * 1 / 100 * goodStockValue;
            goodStockValue += decrease;
            netWorth -= decrease * goodStock;
        }

        if (Random.Range(-1, 2) > 0)
        {
            int increase = Random.Range(1, 10) * 1 / 100 * averageStockValue;
            averageStockValue += increase;
            netWorth += increase * averageStock;
        }
        else
        {
            int decrease = -Random.Range(1, 10) * 1 / 100 * averageStockValue;
            averageStockValue += decrease;
            netWorth -= decrease * averageStock;
        }

        if (Random.Range(-1, 2) > 0)
        {
            int increase = Random.Range(1, 10) * 1 / 100 * badStockValue;
            badStockValue += increase;
            netWorth += increase * badStock;
        }
        else
        {
            int decrease = -Random.Range(1, 10) * 1 / 100 * badStockValue;
            badStockValue += decrease;
            netWorth -= decrease * badStock;
        }

    }


    //// Update is called once per frame
    //void Update()
    //{
    //    cashText.text = "Cash: " + cash;
    //}

}
