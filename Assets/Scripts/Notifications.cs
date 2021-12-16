using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Notifications : MonoBehaviour
{

	public static Notifications Instance { get; private set; }
	public GameObject notifScreen;
	public GameObject achievementScreen;
	private int winGameCount;
	private int loseGameCount;
	private int speedRunnerCount;
	private int stonksCount;

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
		achievementScreen.SetActive(false);
		winGameCount = 0;
		loseGameCount = 0;
		speedRunnerCount = 0;
		stonksCount = 0;
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

        if (Achievement.Instance.winGame == true && winGameCount == 0)
        {
			achievementScreen.SetActive(true);
			winGameCount = winGameCount + 1;
        }

		if (Achievement.Instance.loseGame == true && loseGameCount == 0)
		{
			achievementScreen.SetActive(true);
			loseGameCount = loseGameCount + 1;
		}

		if (Achievement.Instance.speedRunner == true && speedRunnerCount == 0)
		{
			achievementScreen.SetActive(true);
			speedRunnerCount = speedRunnerCount + 1;
		}

		if (Achievement.Instance.Stonks == true && stonksCount == 0)
		{
			achievementScreen.SetActive(true);
			stonksCount = stonksCount + 1;
		}
	}

	public void CloseNotif()
	{
		notifScreen.SetActive(false);
	}
}
