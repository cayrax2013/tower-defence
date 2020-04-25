using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnemyMovement : MonoBehaviour
{
    [SerializeField] private float _maxDistance = 3;

    public float Speed = 10f;

    private GameObject _path;
    private Transform[] _points;
    private int _currentPoint;

    private void Start()
    {
        _path = GameObject.FindGameObjectWithTag("PathForEnemy");

        _points = new Transform[_path.transform.childCount];

        for (int i = 0; i < _path.transform.childCount; i++)
        {
            _points[i] = _path.transform.GetChild(i);
        }
    }

    private void Update()
    {
        Transform target = _points[_currentPoint];

        transform.position = Vector3.MoveTowards(transform.position, target.position, Speed * Time.deltaTime);

        var vectorLenght = (transform.position - _points[_currentPoint].position).magnitude;

        if (vectorLenght < _maxDistance)
        {
            _currentPoint++;

            if (_currentPoint >= _points.Length)
            {
                SceneManager.LoadScene("Level1");
            }
        }
    }
}
