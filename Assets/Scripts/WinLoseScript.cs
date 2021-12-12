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
        //SceneManager.UnloadSceneAsync(SceneManager.GetActiveScene().buildIndex);

        //Resources.UnloadUnusedAssets();

        //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex, LoadSceneMode.Single);
        Code.Instance.cash = 1000;
        Code.Instance.netWorth = 1000;
        Code.Instance.daysPassed = 0;
        Code.Instance.goodStock = 0;
        Code.Instance.badStock = 0;
        Code.Instance.averageStock = 0;
        PopupWin.SetActive(false);

    }


    public void LosePopup()
    {
        //SceneManager.UnloadSceneAsync(SceneManager.GetActiveScene().buildIndex);

        //Resources.UnloadUnusedAssets();

        //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex, LoadSceneMode.Single);

        Code.Instance.cash = 1000;
        Code.Instance.netWorth = 1000;
        Code.Instance.daysPassed = 0;
        Code.Instance.goodStock = 0;
        Code.Instance.badStock = 0;
        Code.Instance.averageStock = 0;
        PopupLose.SetActive(false);
    }
}
