using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BonusControll : MonoBehaviour
{
    [SerializeField] private GameObject[] _bonus;

    bool trigtime = false;
    [SerializeField] private float speedreset = 15f;
    float timer, x;

    void Start()
    {
        timer = speedreset;
    }

    void Update()
    {
        if (timer < 0)
        {
            timer = speedreset;
            trigtime = false;
        }
        if (timer == speedreset)
        {
            x = Random.Range(-2.25f, 2.25f);//Задаем местоположение
            Instantiate(_bonus[Random.Range(0, _bonus.Length)], new Vector2(x, 5.2f), transform.rotation);//Генерация противника из префаба
            trigtime = true;
        }
        if (trigtime == true)
        {
            timer = timer - Time.deltaTime;
        }
    }
}
