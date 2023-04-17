using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : PosXY
{
    public bool isFire;
    [SerializeField] private float speed = 0.006f;

    void Update()
    {
        if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Moved)
        {
            Vector2 touchDeltaPosition = Input.GetTouch(0).deltaPosition;

            transform.Translate(touchDeltaPosition.x * speed, touchDeltaPosition.y * speed, 0 * Time.deltaTime);
            isFire = true;
        }
        else
        {
            isFire = false;
        }

        ControllObject();
    }
}
