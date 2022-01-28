using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target;
    public Vector3 offset;
    [Range(1, 10)]
    public float smoothFactor;

    private void FixedUpdate()
    {
        Follow();
    }

    public void Follow()
    {
        Vector3 targetposition = target.position + offset;
        Vector3 smoothposition = Vector3.Lerp(transform.position, targetposition, smoothFactor * Time.fixedDeltaTime);
        transform.position = smoothposition;    
    }
}
