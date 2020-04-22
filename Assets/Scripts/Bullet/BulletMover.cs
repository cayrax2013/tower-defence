using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletMover : MonoBehaviour
{
    [SerializeField] private float _speed;

    private GameObject _enemy;

    private void Start()
    {
        _enemy = GameObject.FindGameObjectWithTag("Enemy");
    }

    private void Update()
    {
        if (_enemy  != null)
            transform.position = Vector3.MoveTowards(transform.position, _enemy.transform.position, _speed * Time.deltaTime);
        else
            Die();
    }

    private void Die()
    {
        Destroy(gameObject);
    }
}
