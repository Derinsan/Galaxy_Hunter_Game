using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeadPlayer : MonoBehaviour
{
    [SerializeField] private GameObject _loseWindow;
    public static int score;

    void Start()
    {
        _loseWindow.SetActive(false);
    }

    void FixedUpdate()
    {
        if (PlayerState.playerLive == false)
        {
            Invoke("Lose", 2f);
        }
        Debug.Log(score);
    }

    void Lose()
    {
        _loseWindow.SetActive(true);
        Time.timeScale = 0;
    }
}
