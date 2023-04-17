using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundScroll : MonoBehaviour
{
    [SerializeField] private float speed = -0.1f;

    void Update()
    {
        transform.Translate(new Vector3(0f, speed, 0f * Time.deltaTime));
        if (transform.position.y < -9.75f)
        {
            transform.position = new Vector3(0f, 9.50f, 0);
        }
    }
}
