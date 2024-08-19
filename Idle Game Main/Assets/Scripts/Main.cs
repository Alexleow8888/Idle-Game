using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Main : MonoBehaviour
{
   
    private int count;
    public float earn = 1;
    private float total;

    private int IsRunning = 1;
    private int NumberofSeconds = 1;

    public float price;

    public Text price1txt;

    public Text count1txt;


    // Start is called before the first frame update
    void Start()
    {
        Score.currentScore = 10;

        price1txt.text = "Cost : " + price;
    }

    // Update is called once per frame
    void Update()
    {
        price1txt.text = "Cost : " + price;

        count1txt.text = "Count : " + count;

        if (IsRunning == 1)
        {
            StartCoroutine(timer());
        }
    }
    public void counter1()
    {
        IncreaseCount1();
    }
    public void IncreaseCount1()
    {
        if (Score.currentScore >= price)
        {
            count += 1;
            total = earn * count;
            Score.currentScore -= price;
            price *= 1.1f;
            price = Mathf.Round(price);

        }

    }
    public IEnumerator timer()
    {
        IsRunning = 0;
        yield return new WaitForSeconds(NumberofSeconds);
        Score.currentScore += (total);
        IsRunning = 1;
    }

}
