using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloseHelper : MonoBehaviour
{
    public GameObject Helper;
    

    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Close()
    {
        float value = Random.Range(10, 51);
        Helper.SetActive(false);
        Code.Instance.cash += value;
        Code.Instance.netWorth += value;
        Debug.Log(value);
    }
}
