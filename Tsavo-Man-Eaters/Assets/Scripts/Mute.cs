using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mute : MonoBehaviour
{
    public static AudioSource audioSource;

    void Start()
    {
      DontDestroyOnLoad(this.gameObject); //make music persistant
      audioSource = GetComponent<AudioSource>();
    }

    void Update()
    {
      if (Input.GetKeyDown("m"))
          audioSource.mute = !audioSource.mute;
    }
}
