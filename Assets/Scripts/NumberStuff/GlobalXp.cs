﻿using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using UnityEngine.UI;

public class GlobalXp : MonoBehaviour
{
    public GameObject XpDisplay;
    public GameObject SlimeLevelDisplay;

    public static int XpCount;
    public int InternalXpCount;

    public static int LevelCount = 1;
    public int PlayerLevel;

    public static int SlimeLevel;

    private void Update() {
        InternalXpCount = XpCount;
        PlayerLevel = LevelCount;
        SlimeLevel = LevelCount;

        XpDisplay.GetComponent<Text>().text = "Level: " + PlayerLevel + " Xp: " + InternalXpCount + " / " + Math.Pow(2, LevelCount); //display for xp
        switch (GlobalHp.slimeSpawn) {
            case 1:
                SlimeLevelDisplay.GetComponent<Text>().text = "Green Slime - Level: " + SlimeLevel;
                break;
            case 2:
                SlimeLevelDisplay.GetComponent<Text>().text = "Blue Slime - Level: " + SlimeLevel;
                break;
            case 3:
                SlimeLevelDisplay.GetComponent<Text>().text = "Red Slime - Level: " + SlimeLevel;
                break;
            case 4:
                SlimeLevelDisplay.GetComponent<Text>().text = "Yellow Slime - Level: " + SlimeLevel;
                break;
            case 5:
                SlimeLevelDisplay.GetComponent<Text>().text = "Orange Slime - Level: " + SlimeLevel;
                break;
            case 6:
                SlimeLevelDisplay.GetComponent<Text>().text = "Purple Slime - Level: " + SlimeLevel;
                break;
            case 7:
                SlimeLevelDisplay.GetComponent<Text>().text = "White Slime - Level: " + SlimeLevel;
                break;
            case 8:
                SlimeLevelDisplay.GetComponent<Text>().text = "Black Slime - Level: " + SlimeLevel;
                break;
        }

        SlimeLevel = LevelCount;
    }
}
