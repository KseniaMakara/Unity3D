using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
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
   public GameObject Panel;
   public void PauseButton(){
     SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
     Time.timeScale = 1f;
   }
   
}
