using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Transform posTarget;
    public float lerpSpeed = 1.0f;
    private Transform lookTarget;

    private void Awake()
    {
        lookTarget = posTarget.parent;
    }

    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = Vector3.Lerp(transform.position, posTarget.position, 1 - Mathf.Exp(-lerpSpeed * Time.deltaTime));
        transform.LookAt(lookTarget, Vector3.up);
    }
}
