using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
    [SerializeField]
    private float sensitivity, wayWith;

    private GameManager gameManager;
    private void Start()
    {
        gameManager = GameManager.Instance;
    }


    private void FixedUpdate()
    {
        transform.Translate(transform.forward * gameManager.Speed * Time.deltaTime);
    }

    private void Update()
    {
        if (Input.GetKey(KeyCode.Mouse0))
        {
            if (Input.GetAxis("Mouse X") < 0)
            {
                transform.position = Vector3.Lerp(transform.position,
                    new Vector3(transform.position.x - sensitivity, transform.position.y, transform.position.z), .3f);
            }
            else if (Input.GetAxis("Mouse X") > 0)
            {
                transform.position = Vector3.Lerp(transform.position,
                    new Vector3(transform.position.x + sensitivity, transform.position.y, transform.position.z), .3f);
            }
            transform.position = new Vector3(Mathf.Clamp(transform.position.x, -wayWith, wayWith), transform.position.y, transform.position.z);
        }
    }
}
