using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class playAgainButton : MonoBehaviour
{

    public void PlayAgain ()
    {
      SceneManager.LoadScene("LoadingScreen");
    }

}
