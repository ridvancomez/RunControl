using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Karakter : MonoBehaviour
{
    [SerializeField]
    private float speed;


    private void FixedUpdate()
    {
        transform.Translate(transform.forward * speed * Time.deltaTime);
    }
}
