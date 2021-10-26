using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Counter : MonoBehaviour
{

    private Text counterText;
    float timeCounter = 0f;

    // Start is called before the first frame update
    void Start()
    {
        counterText = GetComponent<Text>();
        timeCounter = 1000000f;
    }

    // Update is called once per frame
    void Update()
    {
        timeCounter -= 1 * Time.deltaTime;
        counterText.text = timeCounter.ToString("0");
    }
}
