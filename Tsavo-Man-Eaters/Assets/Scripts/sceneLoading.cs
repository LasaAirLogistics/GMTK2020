using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class sceneLoading : MonoBehaviour
{
    /*private Image progressBar;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(LoadAsyncOperation());
    }

    IEnumerator LoadAsyncOperation()
    {
      yield return new WaitForSeconds(5.0f);

      AsyncOperation gameLevel = SceneManager.LoadSceneAsync("Day1");

    while (gameLevel.progress < 1)
      {
        progressBar.fillAmount = gameLevel.progress;
        yield return new WaitForEndOfFrame();
      }

    }*/

    public string SceneToLoad = "Day1";
    public float DelayTime = 3.0f;

    public void Start()
    {
      StartCoroutine(SceneSwitch());
    }

    private IEnumerator SceneSwitch()
    {
      Debug.Log("apples");
      yield return new WaitForSeconds(DelayTime);

      SceneManager.LoadScene(SceneToLoad, LoadSceneMode.Single);
    }

}
