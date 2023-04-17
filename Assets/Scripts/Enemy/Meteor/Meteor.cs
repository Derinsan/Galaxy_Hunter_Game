using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Meteor : MonoBehaviour
{
    int f;
    float sc;

    void Start()
    {
        f = Random.Range(-5, 5);
        sc = Random.Range(2f, 8f);
        transform.localScale = new Vector3(sc, sc, sc); // Размер
        
    }

    void FixedUpdate()
    {
        transform.rotation *= Quaternion.AngleAxis(f, new Vector3(0, 0, 1)); // Вращение
    }
}
