using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(CharacterController))]
public class PlayerMover : MonoBehaviour
{
    [SerializeField] private float _speed;
    [SerializeField] private float _gravity;
    [SerializeField] private Animator _animator;

    private CharacterController _characterController;
    private Vector3 _direction;

    private void Start()
    {
        _characterController = GetComponent<CharacterController>();
    }

    private void FixedUpdate()
    {
        float moveX = Input.GetAxis("Horizontal");
        float moveZ = Input.GetAxis("Vertical");

        if (_characterController.isGrounded)
        {
            _direction = new Vector3(moveX, 0f, moveZ);
            _direction = transform.TransformDirection(_direction);
        }

        _direction.y -= _gravity * Time.deltaTime;

        _characterController.Move(_direction * Time.deltaTime * _speed);
    }
}
