using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class sceneLoading : MonoBehaviour
{
    private Image _ProgressBar;

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
        _ProgressBar.fillAmount = gameLevel.progress;
        yield return new WaitForEndOfFrame();
      }

    }
}
