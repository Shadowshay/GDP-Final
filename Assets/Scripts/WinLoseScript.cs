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
    }

    public void LosePopup()
    {
        PopupLose.SetActive(false);
    }
}
