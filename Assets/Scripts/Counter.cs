using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Counter : MonoBehaviour
{
    
    private GameManager gameManagerScript;
    public float Count;
    public float point;
    //public static float bet;

    private void Start()
    {
        gameManagerScript = GameObject.Find("Game Manager").GetComponent<GameManager>();
        Count = 0;
    }

    private void OnTriggerEnter(Collider other)
    {
        Count += point;
        gameManagerScript.CounterText.text = "Count : " + Count;
    }
}
