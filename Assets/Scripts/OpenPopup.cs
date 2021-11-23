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
                float goodStockValue = Code.Instance.goodStockValue;
                for (int i = 0; i <= 9; i++)
                {
                    if (UnityEngine.Random.Range(1, 4) > 1)
                    {
                        float increase = UnityEngine.Random.Range(1, 11) / 100f * (float)goodStockValue;
                        // random event changing money here
                        // increase += methodName.effectOnCash.


                        increase = Mathf.Round(increase * 10f) / 10f;
                        //Debug.Log(increase);
                        goodStockValue += (float)increase;
                        goodStockValue = Mathf.Round(goodStockValue * 10f) / 10f;
                        //Debug.Log(goodStockValue);
                        Code.Instance.StockValue.Add(goodStockValue);
                        Code.Instance.StockFluctuations.Add(increase);
                        PopupPanel.gameObject.transform.GetChild(2).GetChild(2).GetChild(i).gameObject.GetComponent<TextMeshProUGUI>().SetText(Code.Instance.StockValue[i].ToString());
                        PopupPanel.gameObject.transform.GetChild(2).GetChild(3).GetChild(i).gameObject.GetComponent<TextMeshProUGUI>().SetText(Code.Instance.StockFluctuations[i].ToString());
                    }
                    else
                    {
                        float decrease = -UnityEngine.Random.Range(1, 11) / 100f * (float)goodStockValue;
                        decrease = Mathf.Round(decrease * 10f) / 10f;
                        goodStockValue += (float)decrease;
                        goodStockValue = Mathf.Round(goodStockValue * 10f) / 10f;
                        Code.Instance.StockValue.Add(goodStockValue);
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
