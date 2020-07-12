using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class calendar : MonoBehaviour
{
  public int day = 0; //variable which stores the day

  // Start is called before the first frame update
  void Start()
  {
    DontDestroyOnLoad(this.gameObject); //because for some reason loading in isn't a scene change
    SceneManager.activeSceneChanged += ChangedActiveScene; //subscribe to ChangedActiveScene
  }

  // Update is called once per frame
  void Update(){} //efficent programing

  private void ChangedActiveScene(Scene current, Scene next){ //is called on scene change
    Debug.Log("LoadScene: " + next.name, gameObject);
     //up the day
    DontDestroyOnLoad(this.gameObject);
    if(next.name == "GameOver"){
      Destroy(this.gameObject);        // reset the counter if the game ends
    } else if(next.name != "LoadingScreen"){
      Debug.Log("change in day!", gameObject);
      day++;
    }
  }
}
