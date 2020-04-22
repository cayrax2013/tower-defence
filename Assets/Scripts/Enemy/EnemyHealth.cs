using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[System.Serializable]
public class UnityEventfloat : UnityEvent<float> { }

public class EnemyHealth : MonoBehaviour
{
    [SerializeField] private UnityEventfloat _healthChanged;
    [SerializeField] private float _currentHealth = 1;

    private void Start()
    {
        _healthChanged?.Invoke(_currentHealth);
    }

    public void TakeDamage(float damage)
    {
        _currentHealth -= damage;

        _healthChanged?.Invoke(_currentHealth);

        if (_currentHealth <= 0)
            Destroy(gameObject);
    }
}
