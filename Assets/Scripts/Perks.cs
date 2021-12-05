using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Perks : MonoBehaviour
{
    public static Perks Instance { get; private set; }

    public bool hasInsurance = false;
    public GameObject companyC;
    public GameObject noMoneyText;

    public GameObject PerkInsurance;
    public GameObject PerkGamblersLuck;
    public GameObject PerkInvestingKnowledge;


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
        bool bought = false;
        if (Code.Instance.cash>= 500 && bought == false) 
        { 
        Code.Instance.luckMultiplier = 15;
            Code.Instance.cash -= 500f;
            Code.Instance.netWorth -= 500f;
        }
        else
        {
            noMoneyText.SetActive(true);
        }
    }

    public void buyInsurance()
    {
        bool bought = false;

        if (Code.Instance.cash >= 500 && bought == false)
        {
            hasInsurance = true;
            Code.Instance.cash -= 500f;
            Code.Instance.netWorth -= 500f;
        }
        else
        {
            noMoneyText.SetActive(true);
        }
    }

    public void investingKnowledge()
    {
        bool bought = false;
        if (Code.Instance.cash >= 500 && bought == false)
        {
            companyC.SetActive(false);
            Code.Instance.cash -= 500f;
            Code.Instance.netWorth -= 500f;
        }
        else
        {
            noMoneyText.SetActive(true);
        }
    }


}
