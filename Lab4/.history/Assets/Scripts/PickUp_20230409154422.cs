using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUp : MonoBehaviour
{
    public int money;
    void OnTriggerEnter(Collider other){
        Destroy(gameObject);
        money++;
    }
}
