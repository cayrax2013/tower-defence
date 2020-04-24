using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletMover : MonoBehaviour
{
    [SerializeField] private float _speed;

    private GameObject[] _enemies;
    private GameObject _nearestEnemy;

    private void Start()
    {
        FindNearestEnemy();
    }

    private void Update()
    {
        if (_enemies != null)
        {
            if (_nearestEnemy != null)
                transform.position = Vector3.MoveTowards(transform.position, _nearestEnemy.transform.position, _speed * Time.deltaTime);
            else
                Die();
        }
        else
            Die();
    }

    private GameObject FindNearestEnemy()
    {
        _enemies = GameObject.FindGameObjectsWithTag("Enemy");

        float distance = Mathf.Infinity;

        foreach (var enemy in _enemies)
        {
            var direction = enemy.transform.position - transform.position;
            float currentDistance = direction.magnitude;

            if (currentDistance < distance)
            {
                _nearestEnemy = enemy;
                distance = currentDistance;
            }
        }

        return _nearestEnemy;
    }

    private void Die()
    {
        Destroy(gameObject);
    }
}
