using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Clicker : MonoBehaviour
{

    public int score = 0;
    public Text scoreText;
    public int mult = 1;

    public Button buy2XButton;

    public void AddPoints()
    {
        score += 1 * mult;
       scoreText.text = "Score: " + score;

    }

    public void Buy2xButtonUpgrade()
    {
        mult = 2;
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