using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerEnemy : MonoBehaviour
{
    [SerializeField] private float _delayBetweenSpawn;
    [SerializeField] private GameObject _enemy;
    [SerializeField] private int _amountEnemies;

    private float _elapsedTime = 0;
    private GameObject[] _enemies;
    private bool _startSpawn = true;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.F1) && _startSpawn)
        {
            _startSpawn = false;
            StartCoroutine(Spawn());
        }
    }

    private IEnumerator Spawn()
    {
        for (int i = 0; i < _amountEnemies; i++)
        {
            var waitForSeconds = new WaitForSeconds(_delayBetweenSpawn);

            Instantiate(_enemy, transform.position, Quaternion.identity);
           
            yield return waitForSeconds;
        }
    }
}
