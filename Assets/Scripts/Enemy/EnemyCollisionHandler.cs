using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCollisionHandler : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.TryGetComponent(out BulletMover bulletMover))
        {

        }
    }
}
