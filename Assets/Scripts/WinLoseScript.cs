using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class WinLoseScript : MonoBehaviour
{
    public GameObject PopupWin;
    public GameObject PopupLose;
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void WinPopup()
    {
        PopupWin.SetActive(false);
        Code.Instance.cash = 1000;
        Code.Instance.netWorth = 1000;
        Code.Instance.daysPassed = 0;
        Code.Instance.goodStock = 0;
        Code.Instance.badStock = 0;
        Code.Instance.averageStock = 0;
    }

    public void LosePopup()
    {
        PopupLose.SetActive(false);
        Code.Instance.cash = 1000;
        Code.Instance.netWorth = 1000;
        Code.Instance.daysPassed = 0;
        Code.Instance.goodStock = 0;
        Code.Instance.badStock = 0;
        Code.Instance.averageStock = 0;
    }
}
