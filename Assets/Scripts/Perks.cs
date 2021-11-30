using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Perks : MonoBehaviour
{
    public static Perks Instance { get; private set; }

    public bool hasInsurance = false;
    public GameObject companyC;

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
        Code.Instance.luckMultiplier = 15;
    }

    public void buyInsurance()
    {
        hasInsurance = true;
    }

    public void investingKnowledge()
    {
        companyC.SetActive(false);
    }


}
