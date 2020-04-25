using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerShooting : MonoBehaviour
{
    [SerializeField] private GameObject _bullet;
    [SerializeField] private float _delayBetweenShots = 2f;

    private float _elapsedTime = 0f;
    private GameObject _enemy;

    private void Update()
    {
        _enemy = GameObject.FindGameObjectWithTag("Enemy");

        _elapsedTime += Time.deltaTime;

        if (_enemy != null)
        {
            if (Vector3.Distance(transform.position, _enemy.transform.position) < 50)
            {
                if (_elapsedTime >= _delayBetweenShots)
                {
                    _elapsedTime = 0f;
                    Instantiate(_bullet, new Vector3(transform.position.x, transform.position.y + 8, transform.position.z), Quaternion.identity);
                }
            }
        }
    }
}
