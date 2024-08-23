using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class PlayerData
{
    public int count1;
    public int count2;
    public int count3;
    public int count4;
    public int count5;
    public float price1;
    public float price2;
    public float price3;
    public float price4;
    public float price5;
    public float prestigeprice;
    public float money;
    public float multiplier;

    public PlayerData (Main main)
    {
        count1 = Main.count1;
        count2 = Main.count2;
        count3 = Main.count3;
        count4 = Main.count4;
        count5 = Main.count5;
        price1 = Main.price1;
        price2 = Main.price2;
        price3 = Main.price3;
        price4 = Main.price4;
        price5 = Main.price5;
        prestigeprice = Main.prestigeprice;
        money = Score.currentScore;
        multiplier = Main.multiplier;

    }
}
