﻿using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;

public class PurchaseButton : MonoBehaviour {

    public GameObject AutoDamageFighter;
    public GameObject AutoDamageArcher;
    public GameObject AutoDamageWarrior;
    public GameObject GreenAutoSell;

    //attackers
    public void StartAutoDamageFigther() {
        AutoDamageFighter.SetActive(true);
        GlobalMoney.MoneyCount -= Convert.ToInt32(GlobalFighter.FighterValue);
        GlobalFighter.FighterLevel += 1;
        GlobalFighter.FighterDamage += 1;
    }

    public void StartAutoDamageArcher() {
        AutoDamageArcher.SetActive(true);
        GlobalMoney.MoneyCount -= Convert.ToInt32(GlobalArcher.ArcherValue);
        GlobalArcher.ArcherLevel += 1;
        GlobalArcher.ArcherDamage += 1;
    }

    public void StartAutoDamageWarrior() {
        AutoDamageWarrior.SetActive(true);
        GlobalMoney.MoneyCount -= Convert.ToInt32(GlobalWarrior.WarriorValue);
        GlobalWarrior.WarriorLevel += 1;
        GlobalWarrior.WarriorDamage += 1;
    }

    //sellers
    public void StartGreenAutoSell() {
        GreenAutoSell.SetActive(true);
        GlobalMoney.MoneyCount -= Convert.ToInt32(GlobalGreenSeller.SellerValue);
        GlobalGreenSeller.SellerLevel += 1;
        GlobalGreenSeller.SellerSPS += 1;
    }

    //sword
    public void UpgradeDamage() {
        GlobalSword.SwordDamageLevel += 1;
        GlobalMoney.MoneyCount -= Convert.ToInt32(GlobalSword.DamageCost);
    }

    public void UpgradeRate(){
        GlobalSword.SwordRateLevel += 1;
        GlobalMoney.MoneyCount -= Convert.ToInt32(GlobalSword.RateCost);
    }

    public void UpgradeCrit() {
        GlobalSword.SwordCritLevel += 1;
        GlobalMoney.MoneyCount -= Convert.ToInt32(GlobalSword.CritCost);
    }

    public void UpgradeCritRaate() {
        GlobalSword.SwordCritRateLevel += 1;
        GlobalMoney.MoneyCount -= Convert.ToInt32(GlobalSword.CritRateCost);
    }
}
