using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Main : MonoBehaviour
{
    
    
    public int button1;
    public static int count1;
    public float earn1 = 1;
    public static float total1;

    // Start is called before the first frame update
    void Start()
    {
        Score.currentScore = 10;
     
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(count1);
        
    }
    public void counter1()
    {
        IncreaseCount1();
    }
    public void IncreaseCount1()
    {
        if (Score.currentScore >= Score.price1)
        {
            count1 = count1 + 1;
            total1 = earn1 * count1;
            Score.currentScore = Score.currentScore - 10;
            Score.price1 = Score.price1 * 1.1f;
            Score.price1 = Mathf.Round(Score.price1);
        }

    }
}
