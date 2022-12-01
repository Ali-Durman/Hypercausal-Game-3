using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIScore : MonoBehaviour
{
    public int score;
    public Text ScoreText;
    public static UIScore Instance;

    private void Awake()
    {
        if (Instance != null)
        {
            Destroy(gameObject);
            return;
        }
        Instance = this;
    }
    public void ScoreInCrease()
    {
        score += 10;
        ScoreText.text = "Score " + score;
    }
}
