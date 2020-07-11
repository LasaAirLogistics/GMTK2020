using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mute : MonoBehaviour
{
    AudioSource audioSource;

    void Start()
    {
      audioSource = GetComponent<AudioSource>();
    }

    void Update()
    {
      if (Input.GetKeyDown("m"))
          audioSource.mute = !audioSource.mute;
    }
}
