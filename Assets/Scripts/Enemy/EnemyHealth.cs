using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[System.Serializable]
public class UnityEventFloat : UnityEvent<float> { }

public class EnemyHealth : MonoBehaviour
{
    [SerializeField] private UnityEventFloat _healthChanged;
    [SerializeField] private float _currentHealth = 1;
    [SerializeField] private int _goldForDie = 50;

    private GameObject _gold;

    private void Start()
    {
        _healthChanged?.Invoke(_currentHealth);
        _gold = GameObject.FindGameObjectWithTag("Gold");
    }

    public void TakeDamage(float damage)
    {
        _currentHealth -= damage;

        _healthChanged?.Invoke(_currentHealth);

        if (_currentHealth <= 0)
            Die();
    }

    private void Die()
    {
        _gold.GetComponent<Gold>().TakeGold(50);
        Destroy(gameObject);
    }
}
