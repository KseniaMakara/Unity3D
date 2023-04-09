using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Timer1 : MonoBehaviour
{
    public float timeStart;
     public Text textTimer;
    void Start() {
          textTimer.text = timeStart.ToString("F2");
     }

     private void Update() {
          timeStart += Time.deltaTime;
          textTimer.text = timeStart.ToString("F2");
     }
}
