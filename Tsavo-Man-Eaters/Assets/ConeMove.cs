using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConeMove : MonoBehaviour
{
    public int coneDist;
    public Transform myGuard;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector2(myGuard.position.x + coneDist, myGuard.position.y);
    }
}
