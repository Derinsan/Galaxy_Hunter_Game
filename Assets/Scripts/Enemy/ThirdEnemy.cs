using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThirdEnemy : MonoBehaviour
{
    private Animator _animator;

    void Start()
    {
        _animator = GetComponent<Animator>();
    }

    void FixedUpdate()
    {
        if (transform.position.y < 3.50f)
        {
            _animator.SetBool("IsAttack", true);

            transform.Translate(0, Random.Range(-0.08f, -0.12f), 0 * Time.deltaTime);
        }
        else
        {
            transform.Translate(0, Random.Range(-0.03f, -0.06f), 0 * Time.deltaTime);
        }
    }
}
