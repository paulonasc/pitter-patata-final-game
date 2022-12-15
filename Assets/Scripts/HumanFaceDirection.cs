using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HumanFaceDirection : MonoBehaviour
{

    // Update is called once per frame
    void Update()
    {
        float temp = transform.position.x - 3f;
        //Debug.Log(transform.position.x + " | " + GlobalBehavior.GlobalBehaviorInstance.playerPos.x);
        if(temp< GlobalBehavior.GlobalBehaviorInstance.playerPos.x)
        {
            gameObject.transform.localScale = new Vector3(3.2f,3.2f,0.7798655f);
        }
        else
        {
            gameObject.transform.localScale = new Vector3(-3.2f,3.2f,0.7798655f);
        }
    }
}
