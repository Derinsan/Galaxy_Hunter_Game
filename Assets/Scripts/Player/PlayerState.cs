using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerState : MonoBehaviour
{
    public int _health;
    private Animator _playerAnimator;
    [SerializeField] private Image[] _healthImage;
    public int _numberOfLives;
    public static bool playerLive;

    void Start()
    {
        _playerAnimator = GetComponent<Animator>();
        playerLive = true;
    }

    void OnCollisionStay2D(Collision2D collisionInfo)
    {
        if (collisionInfo.gameObject.CompareTag("BulletEnemy"))
        {
            _numberOfLives -= 1;
            Destroy(collisionInfo.gameObject);

        }
        if (collisionInfo.gameObject.CompareTag("Meteor"))
        {
            _numberOfLives -= 1;
            Destroy(collisionInfo.gameObject);

        }
        if (collisionInfo.gameObject.CompareTag("Enemy"))
        {
            _numberOfLives -= 1;
            Destroy(collisionInfo.gameObject);

        }
        if (collisionInfo.gameObject.CompareTag("HealthUp"))
        {
            _numberOfLives += 1;
            Destroy(collisionInfo.gameObject);
        }
    }

    void FixedUpdate()
    {
        if (_numberOfLives <= 0)
        {
            _playerAnimator.SetBool("IsDead", true);
            playerLive = false;
            Destroy(gameObject, 1.5f);
        }
    }

    void Update()
    {
        if (_health > _numberOfLives)
        {
            _health = _numberOfLives;
        }

        for (int i = 0; i < _healthImage.Length; i++)
        {
            if (i < _numberOfLives)
            {
                _healthImage[i].enabled = true;
            }
            else
            {
                _healthImage[i].enabled = false;
            }
        }
    }
}
