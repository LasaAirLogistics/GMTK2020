using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.Rendering.Universal;

public class lionSick : MonoBehaviour
{

  Light2D lt;
  float duration = 1.0f;
     Color color0 = Color.red;
     Color color1 = Color.black;

    void Start()
    {
        lt = GetComponent<Light2D> ();
    }

    // Update is called once per frame
    void Update()
    {
      float t = Mathf.PingPong(Time.time, duration) / duration;
      lt.color = Color.Lerp(color0, color1, t);
     }
}
