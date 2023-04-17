using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SystemWeapon : MonoBehaviour
{
    [SerializeField] private GameObject _bullet;
    [SerializeField] private Transform _bulletCenterPosition;
    [SerializeField] private Transform _bulletLeftPosition;
    [SerializeField] private Transform _bulletRightPosition;
    private float curTimeout;
    [SerializeField] private float fireRate = 1;

    PlayerController playerController;
    private bool Upgrade;

    void Start()
    {
        playerController = GetComponent<PlayerController>();
    }

    void FixedUpdate()
    {
        if (playerController.isFire == true && !Upgrade)
        {
            Fire();
        }
        else if (playerController.isFire && Upgrade)
        {
            FireUpgrade();
        }
    }

    void OnCollisionEnter2D(Collision2D collisionInfo)
    {
        if (collisionInfo.gameObject.CompareTag("UpgradeUp"))
        {
            Upgrade = true;
            Destroy(collisionInfo.gameObject);
        }
    }

    void Fire()
    {
        curTimeout += Time.deltaTime;
        if (curTimeout > fireRate)
        {
            curTimeout = 0;
            Instantiate(_bullet, _bulletCenterPosition.position, Quaternion.identity);
        }
    }

    void FireUpgrade()
    {
        Upgrade = true;
        curTimeout += Time.deltaTime;
        if (curTimeout > fireRate)
        {
            curTimeout = 0;
            Instantiate(_bullet, _bulletCenterPosition.position, Quaternion.identity);
            Instantiate(_bullet, _bulletLeftPosition.position, Quaternion.identity);
            Instantiate(_bullet, _bulletRightPosition.position, Quaternion.identity);
        }
    }

    IEnumerator Fireupgrade()
    {
        int i = 0;
        while (i <= 50)
        {
            curTimeout += Time.deltaTime;
            if (curTimeout > fireRate)
            {
                curTimeout = 0;
                Instantiate(_bullet, _bulletCenterPosition.position, Quaternion.identity);
                Instantiate(_bullet, _bulletLeftPosition.position, Quaternion.identity);
                Instantiate(_bullet, _bulletRightPosition.position, Quaternion.identity);
            }
            i++;
            yield return new WaitForSeconds(0.1f);
        }
        Upgrade = false;
    }
}
