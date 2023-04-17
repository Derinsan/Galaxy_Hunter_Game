using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletEnemy : MonoBehaviour
{
    public GameObject[] _bulletEnemy;
    private bool _trigtime = false;
    private float _speedReset = 2f;
    private float _timer;
    private bool _isInZone;

    float x;

    void Start()
    {
        _timer = _speedReset;
    }

    void Update()
    {
        if (gameObject.transform.position.y < 4.5f)
        {
            _isInZone = true;
        }
        else if (gameObject.transform.position.y > 4.5f)
        {
            _isInZone = false;
        }

        if (_timer < 0)
        {
            _timer = _speedReset;
            _trigtime = false;
        }
        if (_timer == _speedReset && _isInZone == true)
        {
            Instantiate(_bulletEnemy[Random.Range(0, _bulletEnemy.Length)], new Vector2(transform.position.x, transform.position.y - 0.4f), transform.rotation);
            _trigtime = true;
        }
        if (_trigtime == true)
        {
            _timer = _timer - Time.deltaTime;
        }
    }
}
