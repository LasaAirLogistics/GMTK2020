using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class lairToNextLevel : MonoBehaviour
{

  private AssetBundle myLoadedAssetBundle;
  private string[] scenePaths;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    public void OnTriggerEnter2D(Collider2D lair)
    {
      if(lair.gameObject.tag == "Lair"){
            SceneManager.LoadScene("Day2");
    }
  }
}
