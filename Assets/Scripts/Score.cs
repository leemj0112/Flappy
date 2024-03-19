using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public static int score = 0;
    public static int BestScore = 0;
    Text uiText;

    void Start()
    {
        uiText = GetComponent<Text>();
        score = 0;
    }

    void Update()
    {
        uiText.text = score.ToString();
    }
}
