using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Button1 : MonoBehaviour
{
    public Text scoreText;

    // Start is called before the first frame update
    void Start()
    {
        Score.price1 = 10;
        scoreText.text = "Cost : " + Score.price1;
        
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = "Cost : " + Score.price1;
    }
}
