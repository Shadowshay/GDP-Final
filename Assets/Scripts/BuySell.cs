using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuySell : MonoBehaviour
{
    
    public GameObject Popup;

    // Start is called before the first frame update
    void Start()
    {

    }


    //Call function after buy button is clicked
    public void BuyGoodStock()
    {

        if (Code.Instance.cash < Code.Instance.StockValue[9])
        {
            PopupBuyPanel();
        }
        else
        {
            Code.Instance.cash -= Code.Instance.StockValue[9];
            Code.Instance.cash = Mathf.Round(Code.Instance.cash * 10f) / 10f;
            Code.Instance.goodStock++;
            Code.Instance.nextDay();
        }

    }

    public void BuyAverageStock()
    {

        if (Code.Instance.cash < Code.Instance.StockValue1[9])
        {
            PopupBuyPanel();
        }
        else
        {
            Code.Instance.cash -= Code.Instance.StockValue1[9];
            Code.Instance.cash = Mathf.Round(Code.Instance.cash * 10f) / 10f;
            Code.Instance.averageStock++;
            Code.Instance.nextDay();
        }

    }

    public void BuyBadStock()
    {

        if (Code.Instance.cash < Code.Instance.StockValue2[9])
        {
            PopupBuyPanel();
        }
        else
        {
            Code.Instance.cash -= Code.Instance.StockValue2[9];
            Code.Instance.cash = Mathf.Round(Code.Instance.cash * 10f) / 10f;
            Code.Instance.badStock++;
            Code.Instance.nextDay();
        }

    }

    //Call function after sell button is clicked
    public void SellGoodStock()
    {
        if (Code.Instance.goodStock > 0)
        {
            Code.Instance.cash = Mathf.Round(Code.Instance.cash * 10f) / 10f;
            Code.Instance.cash += Code.Instance.StockValue[9];
            Code.Instance.goodStock--;
            Code.Instance.nextDay();
        }
        else
        {
            PopupSellPanel();
        }
    }

    public void SellAverageStock()
    {
        if (Code.Instance.averageStock > 0)
        {
            Code.Instance.cash = Mathf.Round(Code.Instance.cash * 10f) / 10f;
            Code.Instance.cash += Code.Instance.StockValue1[9];
            Code.Instance.averageStock--;
            Code.Instance.nextDay();
        }
        else
        {
            PopupSellPanel();
        }
    }
    public void SellBadStock()
    {
        if (Code.Instance.badStock > 0)
        {
            Code.Instance.cash = Mathf.Round(Code.Instance.cash * 10f) / 10f;
            Code.Instance.cash += Code.Instance.StockValue2[9];
            Code.Instance.badStock--;
            Code.Instance.nextDay();
        }
        else
        {
            PopupSellPanel();
        }
    }

    //Call function if no units to sell
    void PopupSellPanel()
    {
        Popup.SetActive(true);

    }

    //Call function if no cash to buy
    void PopupBuyPanel()
    {
        Popup.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
