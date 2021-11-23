using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomEvents : MonoBehaviour
{
	public static RandomEvents Instance { get; private set; }

	public RandomEventAsset[] randomEventAsset;
	private float returnValue;
	private int eventiD;
	//public GameObject Notification;

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

	void Start()
	{
		returnValue = 0;
	}

	public float returnEffectOnStock()
	{
		//get random event id
		int i = Random.Range(0, randomEventAsset.Length);
		returnValue += randomEventAsset[i].EffectOnStock;
		Debug.Log(returnValue);
		return returnValue;
	}

	//public float returnEffectOnCash()
	//   {

	//   }

	// Update is called once per frame
	void Update()
	{

	}
}
