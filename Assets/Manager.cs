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