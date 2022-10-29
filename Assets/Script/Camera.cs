using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    [SerializeField]
    private Transform targetTransform;

    [SerializeField] 
    private Vector3 offset;

    private void LateUpdate()
    {
        transform.position = Vector3.Lerp(transform.position, targetTransform.position - offset, 0.0767f);
    }
}
