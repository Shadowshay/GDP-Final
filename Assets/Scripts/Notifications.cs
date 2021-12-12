using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Notifications : MonoBehaviour
{

    public static Notifications Instance { get; private set; }
    public GameObject notifScreen;

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

    // Start is called before the first frame update
    void Start()
    {
        notifScreen.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OpenNotif()
    {
        if (RandomEvents.Instance.returnValue != 0)
        {
            notifScreen.SetActive(true);
            notifScreen.gameObject.transform.GetChild(1).GetComponent<TextMeshProUGUI>().SetText(RandomEvents.Instance.eventDisc);
        }
        else
        {
            notifScreen.gameObject.transform.GetChild(1).GetComponent<TextMeshProUGUI>().SetText("");
            notifScreen.SetActive(false);
        }
    }

    public void CloseNotif()
    {
        notifScreen.SetActive(false);
    }
}
