using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyState : MonoBehaviour
{
    private Rigidbody2D _rigidbody;
    private Animator _animatorEnemy;

    void Start()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
        _animatorEnemy = GetComponent<Animator>();
    }

    void OnCollisionEnter2D(Collision2D collisionInfo)
    {
        if (collisionInfo.gameObject.tag == "Bullet")
        {
            Destroy(collisionInfo.gameObject);
            DeadPlayer.score += 5;
            _animatorEnemy.SetBool("IsEnemyDead", true);
            Destroy(gameObject, 0.7f);
        }
    }

    void FixedUpdate()
    {
        if (gameObject.transform.position.y <= -7)
        {
            Destroy(gameObject);
        }
    }
}
