using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    [SerializeField] private GameObject _player;

    private void Update()
    {
        if (_player != null)
        {
            transform.position = new Vector3(_player.transform.position.x + 3, _player.transform.position.y + 3f, _player.transform.position.z +3);
        }
        else
            Destroy(gameObject);
    }
}
