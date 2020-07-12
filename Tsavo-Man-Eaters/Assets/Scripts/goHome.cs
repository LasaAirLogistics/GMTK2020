using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class goHome : MonoBehaviour
{
    public void PlayGame()
    {
      SceneManager.LoadScene("Menu");
      Mute.audioSource.Stop();
    }
}
