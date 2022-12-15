using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class potatosackUpdate : MonoBehaviour
{
    public static potatosackUpdate potatosackUpdateInstance;
    public Sprite sp0, sp1, sp2, sp3, sp4;

    void Update()
    {
        if(GlobalBehavior.GlobalBehaviorInstance.count == 1){
            GetComponent<SpriteRenderer>().sprite = sp1;
        }
        if(GlobalBehavior.GlobalBehaviorInstance.count == 2){
            GetComponent<SpriteRenderer>().sprite = sp2;
        }
        if(GlobalBehavior.GlobalBehaviorInstance.count == 3){
            GetComponent<SpriteRenderer>().sprite = sp3;
        }
        if(GlobalBehavior.GlobalBehaviorInstance.count == 4){
            GetComponent<SpriteRenderer>().sprite = sp4;
        }

     
        
    } 
}
