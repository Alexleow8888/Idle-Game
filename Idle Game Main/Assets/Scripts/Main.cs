using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Main : MonoBehaviour
{
   
    public static int count1;
    private float earn1 = 1;
    public static float total1;
    
    public static int count2;
    private float earn2 = 10;
    public static float total2;

    public static int count3;
    private float earn3 = 100;
    public static float total3;

    public static int count4;
    private float earn4 = 1000;
    public static float total4;

    public static int count5;
    private float earn5 = 10000;
    public static float total5;

    // Start is called before the first frame update
    void Start()
    {
        Score.currentScore = 10;
     
    }

    // Update is called once per frame
    void Update()
    {
        
        
    }
    public void counter1()
    {
        IncreaseCount1();
    }
    public void IncreaseCount1()
    {
        if (Score.currentScore >= Score.price1)
        {
            count1 += 1;
            total1 = earn1 * count1;
            Score.currentScore -= Score.price1;
            Score.price1 *= 1.1f;
            Score.price1 = Mathf.Round(Score.price1);
        }

    }
    public void counter2()
    {
        IncreaseCount2();
    }
    public void IncreaseCount2()
    {
        if (Score.currentScore >= Score.price2)
        {
            count2 += 1;
            total2 = earn2 * count2;
            Score.currentScore -= Score.price2;
            Score.price2 *= 1.1f;
            Score.price2 = Mathf.Round(Score.price2);
        }
    }
    public void counter3()
    {
        IncreaseCount3();
    }
    public void IncreaseCount3()
    {
        if (Score.currentScore >= Score.price3)
        {
            count3 += 1;
            total3 = earn3 * count3;
            Score.currentScore -= Score.price3;
            Score.price3 *= 1.1f;
            Score.price3 = Mathf.Round(Score.price3);
        }
    }
    public void counter4()
    {
        IncreaseCount4();
    }
    public void IncreaseCount4()
    {
        if (Score.currentScore >= Score.price4)
        {
            count4 += 1;
            total4 = earn4 * count4;
            Score.currentScore -= Score.price4;
            Score.price4 *= 1.1f;
            Score.price4 = Mathf.Round(Score.price4);
        }
    }
    public void counter5()
    {
        IncreaseCount5();
    }
    public void IncreaseCount5()
    {
        if (Score.currentScore >= Score.price5)
        {
            count5 += 1;
            total5 = earn5 * count5;
            Score.currentScore -= Score.price5;
            Score.price5 *= 1.1f;
            Score.price5 = Mathf.Round(Score.price5);
        }
    }
}
