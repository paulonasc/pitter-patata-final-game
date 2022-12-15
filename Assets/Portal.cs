using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Portal : MonoBehaviour
{   
    [SerializeField] private GameObject destination;

    public GameObject GetDestination(){

        return destination;
    }

}
