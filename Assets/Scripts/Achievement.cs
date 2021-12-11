using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Achievement : MonoBehaviour
{
    public static Achievement Instance { get; private set; }

    public bool winGame;
    public bool Stonks;
    public bool loseGame;
    public bool speedRunner;

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
