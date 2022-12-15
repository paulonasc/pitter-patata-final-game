using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GlobalBehavior : MonoBehaviour
{
    public static GlobalBehavior GlobalBehaviorInstance = null;
    //public AudioSource audioSource;
    public Text PotatoBucket = null;
    
    //bucket picked count
    public int count = 0;
    public int Max_count;
    public Vector2 playerPos = new Vector2();
    //if player could escape or not
    public bool isEscape = false;
    public bool isTimeUp;
    void Start()
    {
        GlobalBehavior.GlobalBehaviorInstance = this;
        Max_count = GameObject.FindGameObjectsWithTag("Bucket").Length;
    }

    void Update()
    {
        PotatoBucket.text = (count + " / " + Max_count);
        UpdateEscapeStatus();
    }

    public void UpdateEscapeStatus()
    {
        if(GameObject.FindGameObjectsWithTag("Bucket").Length == 0)
        {
            isEscape = true;
        } 
    }
    public void PickUp_Bucket()
    {   
        Audioscript.collected = true;
        count = count + 1; 
    }
}
