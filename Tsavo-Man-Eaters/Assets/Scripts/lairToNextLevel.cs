using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System;

public class lairToNextLevel : MonoBehaviour
{
  public string scoreText;
  public bool finished;
  string sceneName;
  Scene m_Scene;
  string day;
  int dayInt;
    // Update is called once per frame
    public void OnTriggerEnter2D(Collider2D lair)
    {
      GameObject canvas = GameObject.Find("Canvas");
      Text[] textValue = canvas.GetComponentsInChildren<Text>();
      scoreText = textValue[0].text;
      if(scoreText == "Go back to den!"){
        finished = true;
      }
      if(lair.gameObject.tag == "Lair" && finished){
        m_Scene = SceneManager.GetActiveScene();
        sceneName = m_Scene.name;
        Debug.Log(sceneName);
        day= sceneName.Substring(sceneName.Length - 1);
        dayInt = Convert.ToInt32(day)+1;
        day = dayInt.ToString();
        SceneManager.LoadScene("Day"+day);
    }
  }
}
