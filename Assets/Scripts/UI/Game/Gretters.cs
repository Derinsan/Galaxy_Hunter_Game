using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Gretters : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _grettersText;
    Score score;

    void Start()
    {
        // _grettersText = GetComponent<TextMeshProUGUI>();

        // if (score.score < 100)
        // {
        //     _grettersText.text = "BAD";
        // }
        // else if (score.score >= 100)
        // {
        //     _grettersText.text = "GOOD";
        // }
    }
}
