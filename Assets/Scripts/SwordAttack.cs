using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwordAttack : MonoBehaviour
{
    [SerializeField] private Animator _animator;
    [SerializeField] private float _damage = 0.05f;
    [SerializeField] private float _delayBetweenHit = 1;

    private bool _attack = false;
    private float _elapsedTime = 0;

    private void Update()
    {
        _elapsedTime += Time.deltaTime;

        if (_elapsedTime >= _delayBetweenHit)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                _animator.SetTrigger("Hit");
                _attack = true;
                _elapsedTime = 0;
            }
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.TryGetComponent(out EnemyHealth enemyHealth))
        {
            if (_attack)
                enemyHealth.TakeDamage(_damage);

            _attack = false;
        }
    }
}
