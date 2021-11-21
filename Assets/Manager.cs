using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class Manager : MonoBehaviour
{
    public Text ClicksTotalText;
    float TotalClicks;

    public Text MoneyTotalText;
    float TotalMoney;

    public Text TotalPlasticText;
    float PlasticLeft;

    private Text score;
    private int scoreAmount;

    public Text scoreText;
    public float scoreAmountt;
    public float pointIncreasedPerSecond;

    private void Start()
    {
        scoreAmount = 1000000;
        score = GetComponent<Text>();

  
        scoreAmountt = 0f;
        pointIncreasedPerSecond = 1f;

    }

    private void Update()
    {
        score.text = scoreAmount.ToString();


        scoreText.text = "Autoclicks: " + (int)scoreAmountt;
        scoreAmountt += pointIncreasedPerSecond * Time.deltaTime;
    }

    public void SubtractScore()
    {
        scoreAmount -= 1;
    }
    public void AddClicks()
    {

        TotalClicks++;

        ClicksTotalText.text = TotalClicks.ToString("0");

    }

    public void AddMoney()
    {

        TotalMoney += 5;

     
        MoneyTotalText.text = TotalMoney.ToString("0");

    }

    public void AddPlastic()
    {

        PlasticLeft -=  1;


        TotalPlasticText.text = PlasticLeft.ToString("0");

    }

    public void MainMenu()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 0);
    }


    
}



