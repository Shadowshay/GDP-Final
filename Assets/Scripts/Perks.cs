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

    public GameObject boughtTextInsurance;
    public GameObject boughtTextGambler;
    public GameObject boughtTextInvesting;



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

        if (Code.Instance.cash>= 500) 
        { 
        Code.Instance.luckMultiplier = 15;
            Code.Instance.cash -= 500f;
            Code.Instance.netWorth -= 500f;
            PerkGamblersLuck.SetActive(false);
            boughtTextGambler.SetActive(true);
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
            Code.Instance.cash -= 500f;
            Code.Instance.netWorth -= 500f;
            PerkInsurance.SetActive(false);
            boughtTextInsurance.SetActive(true);

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
            Code.Instance.cash -= 500f;
            Code.Instance.netWorth -= 500f;
            PerkInvestingKnowledge.SetActive(false);
            boughtTextInvesting.SetActive(true);

            Code.Instance.cash += Code.Instance.badStock * Code.Instance.StockValue2[9];
        }
        else
        {
            noMoneyText.SetActive(true);
        }
    }


}
