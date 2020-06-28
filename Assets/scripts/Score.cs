using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Text scoreTxt;
    public int starValue;
    private int score;
    // Start is called before the first frame update
    void Start()
    {
        score = 0;
        UpdateScore();
    }
    void OnTriggerEnter2D()
    {
        score += starValue;
        UpdateScore();
    }
    // Update is called once per frame
    void UpdateScore()
    {
        scoreTxt.text = "Score: " + score;
    }
}
