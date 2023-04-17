using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class EnemyMove : MonoBehaviour
{
    void FixedUpdate()
    {
        transform.Translate(0, Random.Range(-0.03f, -0.06f), 0 * Time.deltaTime);
    }
}
