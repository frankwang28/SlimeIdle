﻿using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using UnityEngine.UI;

public class DamageButton : MonoBehaviour {

    public GameObject SwordSwing;

    public int CritRand;
    public int HitRand;

    public double CritRate;
    public double HitRate;

	public void ButtonClick () {

        CritRate = GlobalSword.SwordCritRate;
        HitRate = GlobalSword.SwordRate;
        System.Random randomCR = new System.Random();
        System.Random randomHR = new System.Random();
        CritRand = randomCR.Next(1, 101); //between 1 and 100 
        HitRand = randomHR.Next(1, 101); 
        SwordSwing.GetComponent<Animation>().Play("SwordAnim");

        if (HitRand <= HitRate) {
            if (CritRand <= CritRate) {
                GlobalHp.TempHp -= GlobalSword.SwordCrit;
            }
            else {
                GlobalHp.TempHp -= GlobalSword.SwordDamage;
            }
        }
        else{
            //missedAnim;
        }


        GlobalHp.TempHp -= GlobalSword.SwordDamage;

    }
}
