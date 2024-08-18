using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Button1 : MonoBehaviour
{
    public Text price1txt;

    public Text price2txt;

    public Text price3txt;

    public Text price4txt;

    public Text price5txt;

    // Start is called before the first frame update
    void Start()
    {
        Score.price1 = 10;
        price1txt.text = "Cost : " + Score.price1;

        Score.price2 = 100;
        price2txt.text = "Cost : " + Score.price2;

        Score.price3 = 1000;
        price3txt.text = "Cost : " + Score.price3;

        Score.price4 = 10000;
        price4txt.text = "Cost : " + Score.price4;

        Score.price5 = 100000;
        price5txt.text = "Cost : " + Score.price5;
        
    }

    // Update is called once per frame
    void Update()
    {
        price1txt.text = "Cost : " + Score.price1;

        price2txt.text = "Cost : " + Score.price2;

        price3txt.text = "Cost : " + Score.price3;

        price4txt.text = "Cost : " + Score.price4;

        price5txt.text = "Cost : " + Score.price5;
    }
}
