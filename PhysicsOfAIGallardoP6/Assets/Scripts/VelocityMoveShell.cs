using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class VelocityMoveShell : MonoBehaviour
{
    float speed = 3.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.Translate(0, Time.deltaTime * speed * 0.5f, Time.deltaTime * speed);
    }
}
