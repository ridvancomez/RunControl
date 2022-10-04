using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Karakter : MonoBehaviour
{
    [Header("KARAKTER KONTROL VERÝLERÝ")]
    [SerializeField]
    private float speed;

    [SerializeField]
    private float sensitivity;

    private void FixedUpdate()
    {
        transform.Translate(transform.forward * speed * Time.fixedDeltaTime);
    }

    private void Update()
    {
        if (Input.GetMouseButton(0))
        {
            if (Input.GetAxis("Mouse X") < 0)
                transform.position = Vector3.Lerp(transform.position,
                    new Vector3(transform.position.x - sensitivity, transform.position.y, transform.position.z), .3f);
            else if (Input.GetAxis("Mouse X") > 0)
                transform.position = Vector3.Lerp(transform.position,
        new Vector3(transform.position.x + sensitivity, transform.position.y, transform.position.z), .3f);
        }
    }
}
