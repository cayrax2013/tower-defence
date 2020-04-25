using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerEnemy : MonoBehaviour
{
    //Первая волна
    [SerializeField] private float _delayBetweenSpawnForTheFirstWave;
    [SerializeField] private int _amountEnemiesForTheFirstWave;

    //Вторая волна
    [SerializeField] private float _delayBetweenSpawnForTheSecondWawe;
    [SerializeField] private int _amountEnemiesForTheSecondWave;
    
    //Третья волна
    [SerializeField] private float _delayBetweenSpawnForTheThirdWawe;
    [SerializeField] private int _amountEnemiesForTheThirdWave;

    [SerializeField] private GameObject _enemy;

    //Первая волна
    private bool _startSpawnTheFirstWave = true;

    //Вторая волна
    private float _elapsedTimeForTheSecondWaweStart = 0;
    private bool _startSpawnTheSecondWawe = false;

    //Третья волна
    private bool _startSpawnTheThirdWave = false;
    private float _elapsedTimeForTheThirdWaweStart = 0;

    private GameObject[] _enemies;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.F1) && _startSpawnTheFirstWave)
        {
            _startSpawnTheFirstWave = false;
            StartCoroutine(SpawnTheFirstWave());
            _startSpawnTheSecondWawe = true;
        }

        if (_startSpawnTheSecondWawe)
        {
            _elapsedTimeForTheSecondWaweStart += Time.deltaTime;

            if (_elapsedTimeForTheSecondWaweStart >= 30)
            {
                StartCoroutine(SpawnTheSecondWave());
                _startSpawnTheSecondWawe = false;
                _startSpawnTheThirdWave = true;
            }
        }

        if (_startSpawnTheThirdWave)
        {
            _elapsedTimeForTheThirdWaweStart += Time.deltaTime;

            if (_elapsedTimeForTheThirdWaweStart > 30)
            {
                StartCoroutine(SpawnTheThirdWave());
                _startSpawnTheThirdWave = false;
            }
        }
    }

    private IEnumerator SpawnTheFirstWave()
    {
        for (int i = 0; i < _amountEnemiesForTheFirstWave; i++)
        {
            var waitForSeconds = new WaitForSeconds(_delayBetweenSpawnForTheFirstWave);

            Instantiate(_enemy, transform.position, Quaternion.identity);
           
            yield return waitForSeconds;
        }
    }

    private IEnumerator SpawnTheSecondWave()
    {
        for (int i = 0; i < _amountEnemiesForTheSecondWave; i++)
        {
            var waitForSeconds = new WaitForSeconds(_delayBetweenSpawnForTheFirstWave);

            Instantiate(_enemy, transform.position, Quaternion.identity);

            yield return waitForSeconds;
        }
    }

    private IEnumerator SpawnTheThirdWave()
    {
        for (int i = 0; i < _amountEnemiesForTheThirdWave; i++)
        {
            var waitForSeconds = new WaitForSeconds(_delayBetweenSpawnForTheThirdWawe);

            Instantiate(_enemy, transform.position, Quaternion.identity);

            yield return waitForSeconds;
        }
    }
}
