using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class goButton : MonoBehaviour
{
    public void Go ()
    {
      SceneManager.LoadScene("Day1");
    }
}
