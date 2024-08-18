using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Count1 : MonoBehaviour
{
    public Text count1txt;

    public Text count2txt;

    public Text count3txt;

    public Text count4txt;

    public Text count5txt;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        count1txt.text = "Count : " + Main.count1;
        
        count2txt.text = "Count : " + Main.count2;

        count3txt.text = "Count : " + Main.count3;

        count4txt.text = "Count : " + Main.count4;

        count5txt.text = "Count : " + Main.count5;
    }
}
