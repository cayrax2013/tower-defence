using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    [SerializeField] private float _currentHealth;
    [SerializeField] private UnityEventFloat _healthChanged;

    public void TakeHealth(float damage)
    {
        _currentHealth -= damage;
        _healthChanged?.Invoke(_currentHealth);
    }
}
