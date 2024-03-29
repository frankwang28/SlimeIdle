﻿using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;

public class PurchaseButton : MonoBehaviour {

    public GameObject AutoDamageFighter;
    public GameObject AutoDamageArcher;
    public GameObject AutoDamageWarrior;
    public GameObject AutoDamageKnight;
    public GameObject AutoDamageAssassin;
    public GameObject GreenAutoSell;
    public GameObject BlueAutoSell;
    public GameObject RedAutoSell;
    public GameObject YellowAutoSell;
    public GameObject OrangeAutoSell;
    public GameObject AutoGreenProd;
    public GameObject AutoBlueProd;
    public GameObject AutoRedProd;
    public GameObject AutoYellowProd;
    public GameObject AutoOrangeProd;

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

    public void StartAutoDamageKnight() {
        AutoDamageKnight.SetActive(true);
        GlobalMoney.MoneyCount -= Convert.ToInt32(GlobalKnight.KnightValue);
        GlobalKnight.KnightLevel += 1;
        GlobalKnight.KnightDamage += 1;
    }

    public void StartAutoDamageAssassin() {
        AutoDamageAssassin.SetActive(true);
        GlobalMoney.MoneyCount -= Convert.ToInt32(GlobalAssassin.AssassinValue);
        GlobalAssassin.AssassinLevel += 1;
        GlobalAssassin.AssassinDamage += 1;
    }

    //sellers
    public void StartGreenAutoSell() {
        GreenAutoSell.SetActive(true);
        GlobalMoney.MoneyCount -= Convert.ToInt32(GlobalGreenSeller.SellerValue);
        GlobalGreenSeller.SellerLevel += 1;
    }

    public void StartBlueAutoSell() {
        BlueAutoSell.SetActive(true);
        GlobalMoney.MoneyCount -= Convert.ToInt32(GlobalBlueSeller.SellerValue);
        GlobalBlueSeller.SellerLevel += 1;
    }

    public void StartRedAutoSell() {
        RedAutoSell.SetActive(true);
        GlobalMoney.MoneyCount -= Convert.ToInt32(GlobalRedSeller.SellerValue);
        GlobalRedSeller.SellerLevel += 1;
    }

    public void StartYellowAutoSell() {
        YellowAutoSell.SetActive(true);
        GlobalMoney.MoneyCount -= Convert.ToInt32(GlobalYellowSeller.SellerValue);
        GlobalYellowSeller.SellerLevel += 1;
    }

    public void StartOrangeAutoSell() {
        OrangeAutoSell.SetActive(true);
        GlobalMoney.MoneyCount -= Convert.ToInt32(GlobalOrangeSeller.SellerValue);
        GlobalOrangeSeller.SellerLevel += 1;
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

    //production
    public void StartGreenProd() {
        if (GreenHabitat.GreenHabLevel > 0) {
            GlobalSlime.greenSlimeCount -= GreenHabitat.GreenHabValue;
        }
        else {
            GlobalMoney.MoneyCount -= GreenHabitat.unlockValue;
        }
        GreenHabitat.GreenHabLevel += 1;
    }

    public void StartBlueProd() {
        if (BlueHabitat.BlueHabLevel > 0) {
            GlobalSlime.blueSlimeCount -= BlueHabitat.BlueHabValue;
        }
        else {
            GlobalMoney.MoneyCount -= BlueHabitat.unlockValue;
        }
        BlueHabitat.BlueHabLevel += 1;
    }

    public void StartRedProd() {
        if (RedHabitat.RedHabLevel > 0) {
            GlobalSlime.redSlimeCount -= RedHabitat.RedHabValue;
        }
        else {
            GlobalMoney.MoneyCount -= RedHabitat.unlockValue;
        }
        RedHabitat.RedHabLevel += 1;
    }

    public void StartYellowProd() {
        if (YellowHabitat.YellowHabLevel > 0) {
            GlobalSlime.yellowSlimeCount -= YellowHabitat.YellowHabValue;
        }
        else {
            GlobalMoney.MoneyCount -= YellowHabitat.unlockValue;
        }
        YellowHabitat.YellowHabLevel += 1;
    }

    public void StartOrangeProd() {
        if (OrangeHabitat.OrangeHabLevel > 0) {
            GlobalSlime.orangeSlimeCount -= OrangeHabitat.OrangeHabValue;
        }
        else {
            GlobalMoney.MoneyCount -= OrangeHabitat.unlockValue;
        }
        OrangeHabitat.OrangeHabLevel += 1;
    }






}
