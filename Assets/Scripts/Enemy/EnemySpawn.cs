using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawn : MonoBehaviour
{
    public GameObject[] enemy;
    bool trigtime = false;
    [SerializeField] private float speedreset = 2f;
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
            x = Random.Range(-2f, 2f);//Задаем местоположение
            Instantiate(enemy[Random.Range(0, enemy.Length)], new Vector2(x, 7f), transform.rotation);//Генерация противника из префаба
            trigtime = true;
        }
        if (trigtime == true)
        {
            timer = timer - Time.deltaTime;
        }
    }
}
