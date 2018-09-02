using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SmoothCamera : MonoBehaviour {

    public Transform turtle;
    public Vector3 offset;

    public float smoothSpeed = 0.125f;

    void FixedUpdate()
    {
        Vector3 diseredPosition = turtle.position + offset;
        Vector3 smoothedPosition = Vector3.Lerp(transform.position, diseredPosition, smoothSpeed);
        transform.position = smoothedPosition;
    }
    
}
