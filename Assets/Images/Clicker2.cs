using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Clicker2 : MonoBehaviour
{

    public int score = 1000000;
    public Text scoreText;
    public int mult = -1;

    public Button buy2XButton;

    public void AddPoints()
    {
        score -= 1 * mult;
        scoreText.text = "" + score;

    }

    public void Buy2xButtonUpgrade2()
    {
        mult -= -1;
    }

    // Start is called before the first frame update
    void Start()
    {
        buy2XButton.enabled = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (score >= 999800)
        {
            buy2XButton.enabled = false;
        }
        else
        {
            buy2XButton.enabled = true;
        }
    }
}