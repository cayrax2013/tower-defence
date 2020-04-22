using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletCollisionHandler : MonoBehaviour
{
    [SerializeField] private float _damage = 0.34f;

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.TryGetComponent(out EnemyHealth enemyHealth))
        {
            enemyHealth.TakeDamage(_damage);
            Destroy(gameObject);
        }
    }
}
