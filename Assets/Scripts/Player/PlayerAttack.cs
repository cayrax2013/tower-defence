using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : MonoBehaviour
{
    [SerializeField] private GameObject _bullet;
    [SerializeField] private float _delayBetweenShots = 2f;

    private float _elapsedTime = 0f;
    private GameObject _enemy;

    private void Update()
    {
        _enemy = GameObject.FindGameObjectWithTag("Enemy");

        _elapsedTime += Time.deltaTime;

        if (Input.GetKeyDown(KeyCode.Q))
        {
            if (_enemy != null)
            {
                if (Vector3.Distance(transform.position, _enemy.transform.position) < 50)
                {
                    if (_elapsedTime >= _delayBetweenShots)
                    {
                        _elapsedTime = 0f;
                        Instantiate(_bullet, transform.position, Quaternion.identity);
                    }
                }
            }
        }
    }
}
