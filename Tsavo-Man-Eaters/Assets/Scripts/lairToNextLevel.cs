using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class lairToNextLevel : MonoBehaviour
{
  public string scoreText;
  public bool finished;

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
        int rnd = Random.Range(1,7);
        string rnd_str = rnd.ToString();
        SceneManager.LoadScene("Day"+rnd_str);
    }
  }
}
