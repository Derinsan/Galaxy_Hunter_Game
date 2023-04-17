using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletEnemyDirection : MonoBehaviour
{
    [SerializeField] private float _speedBullet = 4f;

    void Start()
    {
        Destroy(gameObject, 4);
    }
    void FixedUpdate()
    {
        transform.position += Vector3.down * _speedBullet * Time.deltaTime;
    }
}
