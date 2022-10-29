using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private static GameManager instance;
    public static GameManager Instance 
    {
        get
        {
            if (instance == null)
                Debug.LogError("Game Manager is null");
            return instance;
        }
    }

    public float Speed;

    public GameObject Target;
    public GameObject PrefabCharacter;
    public GameObject BirthPoint;
    public GameObject ArrivalPoint;

    private void Awake()
    {
        instance = this;
    }

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.A))
        {
            Instantiate(PrefabCharacter, BirthPoint.transform.position, Quaternion.identity);
        }
    }
}
