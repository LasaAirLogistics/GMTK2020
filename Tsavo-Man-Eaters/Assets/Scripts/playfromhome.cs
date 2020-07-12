using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class playfromhome : MonoBehaviour
{
    void dothisnow()
    {
        //Start the coroutine we define below named ExampleCoroutine.
        StartCoroutine(ExampleCoroutine());
    }

    IEnumerator ExampleCoroutine()
    {     SceneManager.LoadScene("About");
          yield return new WaitForSeconds(5);
          SceneManager.LoadScene("About2");
          yield return new WaitForSeconds(5);
          SceneManager.LoadScene("Day1");
    }
}
