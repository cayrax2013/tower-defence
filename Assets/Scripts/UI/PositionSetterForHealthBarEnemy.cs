using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PositionSetterForHealthBarEnemy : MonoBehaviour
{
    [SerializeField] private GameObject _enemy;

    private void Update()
    {
        if (_enemy != null)
            transform.position = new Vector3(_enemy.transform.position.x, _enemy.transform.position.y + 3f, _enemy.transform.position.z);
        else
            Destroy(gameObject);
    }

    private void LateUpdate()
    {
        transform.LookAt(Camera.main.transform);
    }
}
