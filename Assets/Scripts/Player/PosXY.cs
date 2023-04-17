using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PosXY : MonoBehaviour
{
    private float minX, maxX, minY, maxY;

    void Start()
    {
        minX = -2.25f;
        maxX = 2.25f;
        minY = -4.5f;
        maxY = 4.5f;
    }

    public void ControllObject()
    {
        if (transform.position.x < minX)
        {
            transform.position = new Vector2(-2.25f, transform.position.y);
        }
        if (transform.position.x > maxX)
        {
            transform.position = new Vector2(2.25f, transform.position.y);
        }
        if (transform.position.y < minY)
        {
            transform.position = new Vector2(transform.position.x, -4.5f);
        }
        if (transform.position.y > maxY)
        {
            transform.position = new Vector2(transform.position.x, 4.5f);
        }
    }
}
