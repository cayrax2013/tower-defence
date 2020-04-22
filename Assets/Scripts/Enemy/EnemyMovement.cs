using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    [SerializeField] private float _speed = 10f;

    private GameObject _endPoint;

    private void Start()
    {
        _endPoint = GameObject.FindGameObjectWithTag("EndPoint");
    }

    private void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, _endPoint.transform.position, _speed * Time.deltaTime);
    }
}
