using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConeMove : MonoBehaviour
{
    public float coneDist = -1.8f; //the distance the cone should float from the guardBody
    public Transform myGuard; //The guard we are paired with
    public int rotDistance = 90; //how far to rotate  the object while tracking with guardBody

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.position = myGuard.position + transform.up * coneDist; //everyupdate teleport me to myGuard
        transform.rotation = myGuard.rotation * Quaternion.Euler(0,0,rotDistance); //set the right rotation
    }
}
