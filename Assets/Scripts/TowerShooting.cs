using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerShooting : MonoBehaviour
{
    [SerializeField] private GameObject _bullet;
    [SerializeField] private float _delayBetweenShots = 2f;

    private float _elapsedTime = 0f;

    private void Update()
    {
        _elapsedTime += Time.deltaTime;

        if (_elapsedTime >= _delayBetweenShots)
        {
            _elapsedTime = 0f;
            Instantiate(_bullet);
        }
    }
}
