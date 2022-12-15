using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPortal : MonoBehaviour
{   
   
    // bool atPortal = false;

    // Update is called once per frame
    void Update()
    {
        // if(Input.GetKeyDown(KeyCode.E)){
        //     atPortal = true;
        // }
    }

    private void OnTriggerEnter2D(Collider2D other) {
        //if(atPortal == true){
            if(other.CompareTag("BluePortal")){
                // Debug.Log(other.GetComponent<Portal>().GetDestination().transform.position.x);
                // Debug.Log(other.GetComponent<Portal>().GetDestination().transform.position.y);
                this.transform.position = new Vector2(other.GetComponent<Portal>().GetDestination().transform.position.x-2.9f, other.GetComponent<Portal>().GetDestination().transform.position.y+5.4f);
            }
            if(other.CompareTag("GreenPortal")){
                // Debug.Log(other.GetComponent<Portal>().GetDestination().transform.position.x);
                // Debug.Log(other.GetComponent<Portal>().GetDestination().transform.position.y);
                this.transform.position = new Vector2(other.GetComponent<Portal>().GetDestination().transform.position.x-3.5f, other.GetComponent<Portal>().GetDestination().transform.position.y+6f);
            }
            //atPortal = false;
        //}
    }

}

