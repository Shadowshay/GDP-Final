using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Notifications : MonoBehaviour
{

	public static Notifications Instance { get; private set; }
	public GameObject notifScreen;
	public GameObject achievementScreen;

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
	}

	// Update is called once per frame
	void Update()
	{
		
	}

	public void CheckAchievements()
	{
		if (Achievement.Instance.winGame == true || Achievement.Instance.Stonks == true || Achievement.Instance.loseGame == true || Achievement.Instance.speedRunner == true)
		{
			achievementScreen.SetActive(true);
		}
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
