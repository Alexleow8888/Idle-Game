using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Main : MonoBehaviour
{

    private int count1;
    private int count2;
    private int count3;
    private int count4;
    private int count5;

    private float earn1 = 1;
    private float earn2 = 10;
    private float earn3 = 100;
    private float earn4 = 1000;
    private float earn5 = 10000;

    private float total1;
    private float total2;
    private float total3;
    private float total4;
    private float total5;

    private int IsRunning = 1;
    private int NumberofSeconds = 1;

    private float price1 = 10f;
    private float price2 = 100f;
    private float price3 = 1000f;
    private float price4 = 10000f;
    private float price5 = 100000f;

    public Text price1txt;
    public Text price2txt;
    public Text price3txt;
    public Text price4txt;
    public Text price5txt;

    public Text count1txt;
    public Text count2txt;
    public Text count3txt;
    public Text count4txt;
    public Text count5txt;

    public float prestigeprice;

    public Text prestigepricetxt;

    public float multiplier = 1f;

    public Text multipliertxt;

    private float persecond;

    public Text persecondtxt;

    public Text currentmoneytxt;


    // Start is called before the first frame update
    void Start()
    {
        Score.currentScore = 10;

        price1txt.text = "Cost : £" + price1;
        price2txt.text = "Cost : £" + price2;
        price3txt.text = "Cost : £" + price3;
        price4txt.text = "Cost : £" + price4;
        price5txt.text = "Cost : £" + price5;
        
    }

    // Update is called once per frame
    void Update()
    {
        float CurrentScore = Score.currentScore;
        string formmattedcurrentscore = string.Format("{0:N2}", Score.currentScore);
        currentmoneytxt.text = "Money : £" + formmattedcurrentscore;

        float Price1 = price1;
        string formmattedprice1 = string.Format("{0:N0}", price1);

        float Price2 = price2;
        string formmattedprice2 = string.Format("{0:N0}", price2);

        float Price3 = price3;
        string formmattedprice3 = string.Format("{0:N0}", price3);

        float Price4 = price4;
        string formmattedprice4 = string.Format("{0:N0}", price4);

        float Price5 = price5;
        string formmattedprice5 = string.Format("{0:N0}", price5);

        price1txt.text = "Cost : £" + formmattedprice1;
        price2txt.text = "Cost : £" + formmattedprice2;
        price3txt.text = "Cost : £" + formmattedprice3;
        price4txt.text = "Cost : £" + formmattedprice4;
        price5txt.text = "Cost : £" + formmattedprice5;

        count1txt.text = "Count : " + count1;
        count2txt.text = "Count : " + count2;
        count3txt.text = "Count : " + count3;
        count4txt.text = "Count : " + count4;
        count5txt.text = "Count : " + count5;

        if (IsRunning == 1)
        {
            StartCoroutine(timer());
        }

        total1 = earn1 * count1;
        total2 = earn2 * count2;
        total3 = earn3 * count3;
        total4 = earn4 * count4;
        total5 = earn5 * count5;

        persecond = (multiplier * (total1 + total2 + total3 + total4 + total5));

        persecondtxt.text = "£" + persecond + " per second";

        multipliertxt.text = "Multiplier : " + multiplier + "x";

        float PrestigePrice = prestigeprice;
        string formmattedprestigeprice = string.Format("{0:N0}", prestigeprice);
        prestigepricetxt.text = "Cost : £" + formmattedprestigeprice;



    }

    public void counter1button()
    {
        IncreaseCount1();
    }
    public void IncreaseCount1()
    {
        if (Score.currentScore >= price1)
        {
            count1 += 1;
            total1 = earn1 * count1;
            Score.currentScore -= price1;
            price1 *= 1.1f;
            price1 = Mathf.Round(price1);
        }

    }
    public void counter2button()
    {
        IncreaseCount2();
    }
    public void IncreaseCount2()
    {
        if (Score.currentScore >= price2)
        {
            count2 += 1;
            total2 = earn2 * count2;
            Score.currentScore -= price2;
            price2 *= 1.1f;
            price2 = Mathf.Round(price2);
        }

    }
    public void counter3button()
    {
        IncreaseCount3();
    }
    public void IncreaseCount3()
    {
        if (Score.currentScore >= price3)
        {
            count3 += 1;
            total3 = earn3 * count3;
            Score.currentScore -= price3;
            price3 *= 1.1f;
            price3 = Mathf.Round(price3);
        }

    }
    public void counter4button()
    {
        IncreaseCount4();
    }
    public void IncreaseCount4()
    {
        if (Score.currentScore >= price4)
        {
            count4 += 1;
            total4 = earn4 * count4;
            Score.currentScore -= price4;
            price4 *= 1.1f;
            price4 = Mathf.Round(price4);
        }

    }
    public void counter5button()
    {
        IncreaseCount5();
    }
    public void IncreaseCount5()
    {
        if (Score.currentScore >= price5)
        {
            count5 += 1;
            total5 = earn5 * count5;
            Score.currentScore -= price5;
            price5 *= 1.1f;
            price5 = Mathf.Round(price5);
        }

    }
    public void PrestigeButton()
    {
        Prestige();
    }
    public void Prestige()
    {
        if (Score.currentScore >= prestigeprice)
        {
            multiplier += 0.5f;
            multipliertxt.text = "Multiplier : " + multiplier + "x";
            Score.currentScore -= prestigeprice;
            prestigeprice *= 1.5f;
            prestigeprice = Mathf.Round(prestigeprice);
            count1 = 0;
            count2 = 0;
            count3 = 0;
            count4 = 0;
            count5 = 0;
            price1 = 10f;
            price2 = 100f;
            price3 = 1000f;
            price4 = 10000f;
            price5 = 100000f;
            Score.currentScore = 10;
        }
    }

    public IEnumerator timer()
    {
        IsRunning = 0;
        yield return new WaitForSeconds(NumberofSeconds);
        Score.currentScore += (multiplier * (total1 + total2 + total3 + total4 + total5));
        //Debug.Log("Per Second : " + persecond + " Multiplier : " + multiplier);
        IsRunning = 1;
    }

}
