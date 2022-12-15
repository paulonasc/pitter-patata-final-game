using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletBehavior : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {       
        if(collision.gameObject.tag == "Islands")
        {
            Debug.Log(collision);
            Destroy(gameObject);
        }

    }
    
    private void OnBecameInvinsible()
    {
        Destroy(gameObject); 
    }
    
}
