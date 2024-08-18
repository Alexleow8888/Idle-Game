using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NewBehaviourScript : MonoBehaviour
{
    public Text currentmoneytxt;
    public int IsRunning = 1;
    public int NumberofSeconds;
    public Text persecondtxt;
    private float persecond;

    // Update is called once per frame
    void Update()
    {
        persecond = Main.total1 + Main.total2 + Main.total3 + Main.total4 + Main.total5;
        persecondtxt.text = persecond + " £/s";

        
        if (IsRunning == 1)
        {
            StartCoroutine(Wait());
        }
    }
    public IEnumerator Wait()
    {
        IsRunning = 0;
        yield return new WaitForSeconds(NumberofSeconds);
        Score.currentScore += Main.total1 + Main.total2 + Main.total3 + Main.total4 + Main.total5;
        currentmoneytxt.text = "Money : £" + Score.currentScore;
        IsRunning = 1;
    }
}
