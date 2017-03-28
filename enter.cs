using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enter : MonoBehaviour {

public GameObject ctext;
public GameObject atext;
//public GUIText scoreText;
//public int scoreValue;
    private GvrController gvrcontroller;
    public void OnTriggerEnter()
    {
        atext.SetActive(false);
        ctext.SetActive(true);
    }
    public void OnTriggerExit()
    {
      
    atext.SetActive(true);
    ctext.SetActive(false);
   // gvrcontroller.AddScore(scoreValue);
    }

  

    /*  public void AddScore(int newScoreValue)
      {
          score += newScoreValue;
          UpdateScore();
      }

      void UpdateScore()
      {
          scoreText.text = "Score: " + score;
      }
      */
}
