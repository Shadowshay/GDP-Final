//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;

//public class BuySell : MonoBehaviour
//{
//    public Code code;
//    public GameObject Popup;

//    // Start is called before the first frame update
//    void Start()
//    {
        
//    }

    
//    //Call function after buy button is clicked
//    public void Buy()
//    {
        
//        if (code.cash < code.averageStockValue)
//        {
//            PopupBuyPanel();
//        }
//        else
//        {
//            code.cash -= code.averageStockValue;
//            code.unitsOwned++;
//        }
//    }

//    //Call function after sell button is clicked
//    public void Sell()
//    {
//        if (code.unitsOwned > 0)
//        {
//            code.cash += code.averageStockValue;
//            code.unitsOwned--;
//        }
//        else
//        {
//            PopupSellPanel();
//        }
//    }

//    //Call function if no units to sell
//    void PopupSellPanel()
//    {
//        Popup.SetActive(true);
//    }

//    //Call function if no cash to buy
//    void PopupBuyPanel()
//    {
//        Popup.SetActive(true);
//    }

//    // Update is called once per frame
//    void Update()
//    {

//    }
//}
