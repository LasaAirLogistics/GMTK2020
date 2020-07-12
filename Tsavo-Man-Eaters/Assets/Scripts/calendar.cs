using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class calendar : MonoBehaviour
{
  private int day = 0;

  // Start is called before the first frame update
  void Start()
  {
    DontDestroyOnLoad(this.gameObject);
    SceneManager.activeSceneChanged += ChangedActiveScene;
  }

  // Update is called once per frame
  void Update()
  {

  }

  private void ChangedActiveScene(Scene current, Scene next){
    Debug.Log("LoadScene: " + next.name, gameObject);
    day++;
    if(next.name != "GameOver"){
      DontDestroyOnLoad(this.gameObject);
    } else {
      Destroy(this.gameObject);
    }
  }
}
