using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _textScore;
    void Start()
    {
        _textScore = GetComponent<TextMeshProUGUI>();
        _textScore.text = $"Score: {DeadPlayer.score}";
    }
}
