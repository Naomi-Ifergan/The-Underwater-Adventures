using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Clicker3 : MonoBehaviour
{

    public int score = 0;
    public Text scoreText;
    public int mult = 5;

    public Button buy2XButton;

    public void AddPoints()
    {
        score += 1 * mult;
        scoreText.text = " " + score;

    }

    public void Buy2xButtonUpgrade3()
    {
        mult = 10;
    }

    // Start is called before the first frame update
    void Start()
    {
        buy2XButton.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (score >= 50)
        {
            buy2XButton.enabled = true;

        }
        else
        {
            buy2XButton.enabled = false;
        }
    }
}