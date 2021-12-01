using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;
public class OpenPopup : MonoBehaviour
{
    public GameObject PopupPanel;
    
    public void OpenPanel()
    {
        if (PopupPanel != null)
        {
            if (gameObject.name == "Company A" && Code.Instance.daysPassed == 0)
            {
                
                for (int i = 0; i <= 9; i++)
                {
                    if (UnityEngine.Random.Range(1, 6) > 2)
                    {
                        float increase = UnityEngine.Random.Range(1, 11) / 100f * (float)Code.Instance.goodStockValue;
                        // random event changing money here
                        // increase += methodName.effectOnCash.


                        increase = Mathf.Round(increase * 10f) / 10f;
                        //Debug.Log(increase);
                        Code.Instance.goodStockValue += increase;
                        Code.Instance.goodStockValue = Mathf.Round(Code.Instance.goodStockValue * 10f) / 10f;
                        //Debug.Log(goodStockValue);
                        Code.Instance.StockValue.Add(Code.Instance.goodStockValue);
                        Code.Instance.StockFluctuations.Add(increase);
                        PopupPanel.gameObject.transform.GetChild(2).GetChild(2).GetChild(i).gameObject.GetComponent<TextMeshProUGUI>().SetText(Code.Instance.StockValue[i].ToString());
                        PopupPanel.gameObject.transform.GetChild(2).GetChild(3).GetChild(i).gameObject.GetComponent<TextMeshProUGUI>().SetText(Code.Instance.StockFluctuations[i].ToString());
                    }
                    else
                    {
                        float decrease = -UnityEngine.Random.Range(1, 11) / 100f * (float)Code.Instance.goodStockValue;
                        decrease = Mathf.Round(decrease * 10f) / 10f;
                        Code.Instance.goodStockValue += decrease;
                        Code.Instance.goodStockValue = Mathf.Round(Code.Instance.goodStockValue * 10f) / 10f;
                        Code.Instance.StockValue.Add(Code.Instance.goodStockValue);
                        Code.Instance.StockFluctuations.Add(decrease);
                        PopupPanel.gameObject.transform.GetChild(2).GetChild(2).GetChild(i).gameObject.GetComponent<TextMeshProUGUI>().SetText(Code.Instance.StockValue[i].ToString());
                        PopupPanel.gameObject.transform.GetChild(2).GetChild(3).GetChild(i).gameObject.GetComponent<TextMeshProUGUI>().SetText(Code.Instance.StockFluctuations[i].ToString());
                    }
                }
            }
            if (gameObject.name == "Company A" && Code.Instance.daysPassed > 0)
            {

                for (int i = 0; i <= 9; i++)
                {
                    PopupPanel.gameObject.transform.GetChild(2).GetChild(2).GetChild(i).gameObject.GetComponent<TextMeshProUGUI>().SetText(Code.Instance.StockValue[i].ToString());
                    PopupPanel.gameObject.transform.GetChild(2).GetChild(3).GetChild(i).gameObject.GetComponent<TextMeshProUGUI>().SetText(Code.Instance.StockFluctuations[i].ToString());
                }
            }

        PopupPanel.SetActive(true);
        }
    }
}
