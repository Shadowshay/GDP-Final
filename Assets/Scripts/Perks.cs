using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Perks : MonoBehaviour
{
    public static Perks Instance { get; private set; }

    public bool hasInsurance = false;
    public GameObject companyC;
    public GameObject noMoneyText;

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

    public void gamblersLuck()
    {
        if(Code.Instance.cash>= 500) 
        { 
        Code.Instance.luckMultiplier = 15;
        }
        else
        {
            noMoneyText.SetActive(true);
        }
    }

    public void buyInsurance()
    {

        if (Code.Instance.cash >= 500)
        {
            hasInsurance = true;
        }
        else
        {
            noMoneyText.SetActive(true);
        }
    }

    public void investingKnowledge()
    {

        if (Code.Instance.cash >= 500)
        {
            companyC.SetActive(false);
        }
        else
        {
            noMoneyText.SetActive(true);
        }
    }


}
