using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class SubCharacter : MonoBehaviour
{
    private GameObject target;
    NavMeshAgent nawMesnh;
    GameManager gameManager;
    private void Start()
    {
        gameManager = GameManager.Instance;
        nawMesnh = GetComponent<NavMeshAgent>();
        nawMesnh.speed = gameManager.Speed + 0.25f;
        target = gameManager.ArrivalPoint;
    }
    private void LateUpdate()
    {
        nawMesnh.SetDestination(target.transform.position);
    }
}
