using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUp : MonoBehaviour
{
    int money;
    void OnTriggerEnter(Collider other){
        Destroy(gameObject);
        money++;
    }
}
