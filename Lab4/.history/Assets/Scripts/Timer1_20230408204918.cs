using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Timer1 : MonoBehaviour
{
   
    void Start() {
          textTimer.text = timeStart.ToString("F2");
     }

     private void Update() {
          timeStart += Time.deltaTime;
          textTimer.text = timeStart.ToString("F2");
     }
}
