using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NewBehaviourScript : MonoBehaviour
{

    public int score = 0;
    public Text scoreText;
    public int mult = 1;

    public Button Buy2XButton;

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
        Buy2XButton.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (score >= 10){
            Buy2XButton.enabled = true;
        }
        else{
            Buy2XButton.enabled = false;
        }
    }
}
