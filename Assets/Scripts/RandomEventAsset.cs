using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "RandomEvents")]
[System.Serializable]

public class RandomEventAsset : ScriptableObject
{
	public int EventID;
	public string Description;
	public int EffectOnStock;
	public float EffectOnCash;
}
