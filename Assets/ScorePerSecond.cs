using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScorePerSecond : MonoBehaviour
{
   
    public Text scoreText;
    public float scoreAmountt;
    public float pointIncreasedPerSecond;

    // Start is called before the first frame update
    void Start()
    {
        scoreAmountt = 0f;
        pointIncreasedPerSecond = 1f;



    }

    // Update is called once per frame
    void Update()
    {
     

        scoreText.text = "Autoclicks: " + (int)scoreAmountt ;
        scoreAmountt += pointIncreasedPerSecond * Time.deltaTime;
    }


}
