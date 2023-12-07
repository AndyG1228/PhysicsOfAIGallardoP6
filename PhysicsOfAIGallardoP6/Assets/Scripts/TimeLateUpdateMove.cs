using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeLateUpdateMove : MonoBehaviour
{
    public float speed = 0.5f;

    void LateUpdate()
    {
        this.transform.Translate(0, 0, Time.deltaTime * speed);
    }
}
