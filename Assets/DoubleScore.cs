using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DoubleScore : MonoBehaviour
{

    private Text score;
    private int doubleScore;


    void Start()
    {
        doubleScore = 0;
        score = GetComponent<Text>();
    }

    private void Update()
    {
        score.text = doubleScore.ToString();
    }

    public void AddScore()
    {
        doubleScore += 10;
    }
}
