using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwordEnemyAttack : MonoBehaviour
{
    [SerializeField] private float _damage = 0.2f;
    [SerializeField] private Animator _animator;

    private void Update()
    {
        var player = GameObject.FindGameObjectWithTag("Player");

        if (Vector3.Distance(transform.position, player.transform.position) < 5)
            _animator.SetTrigger("Hit");
    }

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.TryGetComponent(out PlayerAttack playerHealth))
        {
            playerHealth.GetComponent<PlayerHealth>().TakeHealth(_damage);
            Debug.Log("Sword");
        }
    }
}
