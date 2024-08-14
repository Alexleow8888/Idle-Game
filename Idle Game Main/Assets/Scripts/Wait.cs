using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NewBehaviourScript : MonoBehaviour
{
    public Text scoreText;
    public int IsRunning = 1;
    public int NumberofSeconds;


    // Update is called once per frame
    void Update()
    {
        
        if (IsRunning == 1)
        {
            StartCoroutine(Wait());
        }
    }
    public IEnumerator Wait()
    {
        IsRunning = 0;
        yield return new WaitForSeconds(NumberofSeconds);
        Score.currentScore += Main.total1;
        scoreText.text = "Money : " + Score.currentScore;
        IsRunning = 1;
    }
}
