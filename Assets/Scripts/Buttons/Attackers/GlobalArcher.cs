﻿using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using UnityEngine.UI;

public class GlobalArcher : MonoBehaviour {


    public GameObject fakeButton;
    public GameObject realButton;
    public GameObject fakeText;
    public GameObject realText;
    public GameObject ArcherStat;

    public int currentMoney;
    public static double ArcherValue; //cost
    public int displayArcherValue; //god im being trolled
    public static int ArcherLevel; //level of fighter

    public static double ArcherDamage; //damage dealt
    public static float DamageRate;
    public static double CritDamage;
    public static float CritRate;

    public static float HitRate;

    public static double ArcherDPS;

    void Update() {
        ArcherValue = 40 * Math.Pow(1.5, ArcherLevel);
        ArcherDamage = 6 * Math.Pow(1.5, ArcherLevel - 1);
        DamageRate = 100;
        CritDamage = ArcherDamage * 2;
        CritRate = 0;
        HitRate = 1.2f;
        ArcherDPS = ArcherDamage / HitRate;
        currentMoney = GlobalMoney.MoneyCount;

        if (ArcherLevel == 0) {
            ArcherStat.GetComponent<Text>().text = "Lvl.0";
        }
        else {
            ArcherStat.GetComponent<Text>().text = "Lvl." + ArcherLevel + " (" + Convert.ToInt32(ArcherDPS) + " DPS)";
        }

        displayArcherValue = Convert.ToInt32(ArcherValue);

        if (ArcherLevel == 0) { //lvl statements
            fakeText.GetComponent<Text>().text = "Hire Archer - $" + displayArcherValue; //button display
            realText.GetComponent<Text>().text = "Hire Archer - $" + displayArcherValue;
        }
        else {
            fakeText.GetComponent<Text>().text = "Upgrade Archer - $" + displayArcherValue;
            realText.GetComponent<Text>().text = "Upgrade Archer - $" + displayArcherValue;
        }

        if (currentMoney >= ArcherValue) {
            fakeButton.SetActive(false); //deactivate fake
            realButton.SetActive(true);  //activate real
        }
        else {
            realButton.SetActive(false); //deactivate real
            fakeButton.SetActive(true);  //activate fake
        }
    }
}