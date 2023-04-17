using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeteorRotate : MonoBehaviour
{
    [SerializeField] private float _speedMeteor;
    [SerializeField] private GameObject _explosion;

    void Start()
    {
        Destroy(gameObject, 5f);
    }

    void Update()
    {
        transform.Translate(new Vector3(0, _speedMeteor, 0f));
    }

    void OnCollisionEnter2D(Collision2D collisionInfo)
    {
        if (collisionInfo.gameObject.tag == "Bullet")
        {
            Destroy(collisionInfo.gameObject);
            DeadPlayer.score += 5;
            //Instantiate(_explosion, transform.position, transform.rotation);
            //Destroy(_explosion, 1f);
            Destroy(gameObject);
        }
    }
}
