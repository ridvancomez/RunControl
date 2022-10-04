using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kamera : MonoBehaviour
{
    [SerializeField]
    private Transform followTransform;

    [SerializeField]
    private Vector3 offSet;

    private void LateUpdate()
    {
        transform.position = Vector3.Lerp(transform.position, followTransform.position - offSet, 0.085f);
    }
}
