using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedEnemyChanger : MonoBehaviour
{
    [SerializeField] private float _speed;

    private void OnTriggerEnter(Collider other)
    {
        if (other.TryGetComponent(out EnemyMovement enemyMovement))
        {
            enemyMovement.Speed = _speed;
        }
    }
}
