using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletDirection : MonoBehaviour
{
    [SerializeField] private float _speed = 5f;
    [SerializeField] private AudioSource _audioSource;

    void Start()
    {
        Destroy(gameObject, 10);
        _audioSource = GetComponent<AudioSource>();
        _audioSource.Play();
    }
    void FixedUpdate()
    {
        transform.position += Vector3.up * _speed * Time.deltaTime;
    }

    void Update()
    {
        if (transform.position.y >= 5.05)
        {
            Destroy(gameObject);
        }
    }
}
