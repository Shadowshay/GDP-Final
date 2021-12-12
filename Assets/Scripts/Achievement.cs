using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Achievement : MonoBehaviour
{
	public static Achievement Instance { get; private set; }

	public bool winGame = false;
	public bool Stonks = false;
	public bool loseGame = false;
	public bool speedRunner = false;

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
}
