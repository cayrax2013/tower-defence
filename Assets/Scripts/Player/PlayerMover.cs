using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(CharacterController))]
public class PlayerMover : MonoBehaviour
{
    [SerializeField] private float _speed = 10f;
    [SerializeField] private float _gravity = 20f;

    private Vector3 _direction;
    private CharacterController _controller;

    private void Start()
    {
        _controller = GetComponent<CharacterController>();
    }

    private void Update()
    {
        float moveX = Input.GetAxis("Horizontal");
        float moveZ = Input.GetAxis("Vertical");

        if (_controller.isGrounded)
        {
            _direction = new Vector3(moveX, 0f, moveZ);
            _direction = transform.TransformDirection(_direction) * _speed;
        }

        _direction.y -= _gravity * Time.deltaTime;
        _controller.Move(_direction * Time.deltaTime);
    }
}
