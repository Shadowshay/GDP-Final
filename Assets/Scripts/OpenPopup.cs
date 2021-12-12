using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;
public class OpenPopup : MonoBehaviour
{
    public GameObject PopupPanel;
    bool firstTimeGood = true;
    bool firstTimeAverage = true;
    bool firstTimeBad = true;
    public void OpenPanel()
    {
        if (PopupPanel != null)
        {
            if (gameObject.name == "Company A" && firstTimeGood == true)
            {
                
                for (int i = 0; i <= 9; i++)
                {
                    if (UnityEngine.Random.Range(1, 6) > 2)
                    {
                        float increase = UnityEngine.Random.Range(1, Code.Instance.luckMultiplier +1) / 100f * (float)Code.Instance.goodStockValue;
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
                        float decrease = -UnityEngine.Random.Range(1, Code.Instance.luckMultiplier + 1) / 100f * (float)Code.Instance.goodStockValue;
                        decrease = Mathf.Round(decrease * 10f) / 10f;
                        Code.Instance.goodStockValue += decrease;
                        Code.Instance.goodStockValue = Mathf.Round(Code.Instance.goodStockValue * 10f) / 10f;
                        Code.Instance.StockValue.Add(Code.Instance.goodStockValue);
                        Code.Instance.StockFluctuations.Add(decrease);
                        PopupPanel.gameObject.transform.GetChild(2).GetChild(2).GetChild(i).gameObject.GetComponent<TextMeshProUGUI>().SetText(Code.Instance.StockValue[i].ToString());
                        PopupPanel.gameObject.transform.GetChild(2).GetChild(3).GetChild(i).gameObject.GetComponent<TextMeshProUGUI>().SetText(Code.Instance.StockFluctuations[i].ToString());

                    }


                }

                firstTimeGood = false;
            }
            if (gameObject.name == "Company A" && firstTimeGood == false)
            {

                for (int i = 0; i <= 9; i++)
                {
                    PopupPanel.gameObject.transform.GetChild(2).GetChild(2).GetChild(i).gameObject.GetComponent<TextMeshProUGUI>().SetText(Code.Instance.StockValue[i].ToString());
                    PopupPanel.gameObject.transform.GetChild(2).GetChild(3).GetChild(i).gameObject.GetComponent<TextMeshProUGUI>().SetText(Code.Instance.StockFluctuations[i].ToString());
                }
            }

            if (gameObject.name == "Company B" && firstTimeAverage == true)
            {

                for (int i = 0; i <= 9; i++)
                {
                    if (UnityEngine.Random.Range(1, 3) > 1)
                    {
                        float increase = UnityEngine.Random.Range(1, Code.Instance.luckMultiplier + 1) / 100f * (float)Code.Instance.averageStockValue;
                        // random event changing money here
                        // increase += methodName.effectOnCash.


                        increase = Mathf.Round(increase * 10f) / 10f;
                        //Debug.Log(increase);
                        Code.Instance.averageStockValue += increase;
                        Code.Instance.averageStockValue = Mathf.Round(Code.Instance.averageStockValue * 10f) / 10f;
                        //Debug.Log(goodStockValue);
                        Code.Instance.StockValue1.Add(Code.Instance.averageStockValue);
                        Code.Instance.StockFluctuations1.Add(increase);
                        PopupPanel.gameObject.transform.GetChild(2).GetChild(2).GetChild(i).gameObject.GetComponent<TextMeshProUGUI>().SetText(Code.Instance.StockValue1[i].ToString());
                        PopupPanel.gameObject.transform.GetChild(2).GetChild(3).GetChild(i).gameObject.GetComponent<TextMeshProUGUI>().SetText(Code.Instance.StockFluctuations1[i].ToString());
                    }
                    else
                    {
                        float decrease = -UnityEngine.Random.Range(1, Code.Instance.luckMultiplier + 1) / 100f * (float)Code.Instance.averageStockValue;
                        decrease = Mathf.Round(decrease * 10f) / 10f;
                        Code.Instance.averageStockValue += decrease;
                        Code.Instance.averageStockValue = Mathf.Round(Code.Instance.averageStockValue * 10f) / 10f;
                        Code.Instance.StockValue1.Add(Code.Instance.averageStockValue);
                        Code.Instance.StockFluctuations1.Add(decrease);
                        PopupPanel.gameObject.transform.GetChild(2).GetChild(2).GetChild(i).gameObject.GetComponent<TextMeshProUGUI>().SetText(Code.Instance.StockValue1[i].ToString());
                        PopupPanel.gameObject.transform.GetChild(2).GetChild(3).GetChild(i).gameObject.GetComponent<TextMeshProUGUI>().SetText(Code.Instance.StockFluctuations1[i].ToString());
                    }
                }

                firstTimeAverage = false;
            }
            if (gameObject.name == "Company B" && firstTimeAverage == false)
            {

                for (int i = 0; i <= 9; i++)
                {
                    PopupPanel.gameObject.transform.GetChild(2).GetChild(2).GetChild(i).gameObject.GetComponent<TextMeshProUGUI>().SetText(Code.Instance.StockValue1[i].ToString());
                    PopupPanel.gameObject.transform.GetChild(2).GetChild(3).GetChild(i).gameObject.GetComponent<TextMeshProUGUI>().SetText(Code.Instance.StockFluctuations1[i].ToString());
                }
            }

            if (gameObject.name == "Company C" && firstTimeBad == true)
            {

                for (int i = 0; i <= 9; i++)
                {
                    if (UnityEngine.Random.Range(1,6) > 3)
                    {
                        float increase = UnityEngine.Random.Range(1, Code.Instance.luckMultiplier + 1) / 100f * (float)Code.Instance.badStockValue;
                        // random event changing money here
                        // increase += methodName.effectOnCash.


                        increase = Mathf.Round(increase * 10f) / 10f;
                        //Debug.Log(increase);
                        Code.Instance.badStockValue += increase;
                        Code.Instance.badStockValue = Mathf.Round(Code.Instance.badStockValue * 10f) / 10f;
                        //Debug.Log(goodStockValue);
                        Code.Instance.StockValue2.Add(Code.Instance.badStockValue);
                        Code.Instance.StockFluctuations2.Add(increase);
                        PopupPanel.gameObject.transform.GetChild(2).GetChild(2).GetChild(i).gameObject.GetComponent<TextMeshProUGUI>().SetText(Code.Instance.StockValue2[i].ToString());
                        PopupPanel.gameObject.transform.GetChild(2).GetChild(3).GetChild(i).gameObject.GetComponent<TextMeshProUGUI>().SetText(Code.Instance.StockFluctuations2[i].ToString());
                    }
                    else
                    {
                        float decrease = -UnityEngine.Random.Range(1, Code.Instance.luckMultiplier + 1) / 100f * (float)Code.Instance.badStockValue;
                        decrease = Mathf.Round(decrease * 10f) / 10f;
                        Code.Instance.badStockValue += decrease;
                        Code.Instance.badStockValue = Mathf.Round(Code.Instance.badStockValue * 10f) / 10f;
                        Code.Instance.StockValue2.Add(Code.Instance.badStockValue);
                        Code.Instance.StockFluctuations2.Add(decrease);
                        PopupPanel.gameObject.transform.GetChild(2).GetChild(2).GetChild(i).gameObject.GetComponent<TextMeshProUGUI>().SetText(Code.Instance.StockValue2[i].ToString());
                        PopupPanel.gameObject.transform.GetChild(2).GetChild(3).GetChild(i).gameObject.GetComponent<TextMeshProUGUI>().SetText(Code.Instance.StockFluctuations2[i].ToString());
                    }
                }
                firstTimeBad = false;
            }
            if (gameObject.name == "Company C" && firstTimeBad == false)
            {

                for (int i = 0; i <= 9; i++)
                {
                    PopupPanel.gameObject.transform.GetChild(2).GetChild(2).GetChild(i).gameObject.GetComponent<TextMeshProUGUI>().SetText(Code.Instance.StockValue2[i].ToString());
                    PopupPanel.gameObject.transform.GetChild(2).GetChild(3).GetChild(i).gameObject.GetComponent<TextMeshProUGUI>().SetText(Code.Instance.StockFluctuations2[i].ToString());
                }
            }


            PopupPanel.SetActive(true);
        }
    }
}
