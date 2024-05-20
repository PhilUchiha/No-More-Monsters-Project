using System.Collections;
using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

[Serializable]
public class Data
{

    public double Gold;

#region U1
    //upgrade1
    public double u1Cost
    {
        get
        {
        return 5 * System.Math.Pow(1.15, u1Level);
        }
    }
    public double u1Level;
    public float u1Timer;
    public float u1TimeCap;
    public double u1Mult;
    public bool hasRun1;
    public double u1Power
    {
    
        get
        {
            return u1Level * u1Mult;
        }
    }

    public bool u1Auto;
#endregion
#region U2
        //upgrade2
    public double u2Cost
    {
        get
        {
        return 250 * System.Math.Pow(1.20, u2Level);
        }
    }
    public double u2Level;
    public float u2Timer;
    public float u2TimeCap;
    public double u2Mult;
    public bool hasRun2;
    public double u2Power
    {
    
        get
        {
            return 10 * u2Level * u2Mult;
        }
    }

    public bool u2Auto;
#endregion
#region U3
        //upgrade3
    public double u3Cost
    {
        get
        {
        return 18750 * System.Math.Pow(1.25, u3Level);
        }
    }
    public double u3Level;
    public float u3Timer;
    public float u3TimeCap;
    public double u3Mult;
    public bool hasRun3;
    public double u3Power
    {
    
        get
        {
            return 150 * u3Level * u3Mult;
        }
    }

    public bool u3Auto;
#endregion
#region U4
           //upgrade4
    public double u4Cost
    {
        get
        {
        return 50000 * System.Math.Pow(1.30, u4Level);
        }
    }
    public double u4Level;
    public float u4Timer;
    public float u4TimeCap;
    public double u4Mult;
    public bool hasRun4;
    public double u4Power
    {
    
        get
        {
            return 150 * u4Level * u4Mult;
        }
    }

    public bool u4Auto;

#endregion
#region U5
           //upgrade5
    public double u5Cost
    {
        get
        {
        return 100000 * System.Math.Pow(1.35, u5Level);
        }
    }
    public double u5Level;
    public float u5Timer;
    public float u5TimeCap;
    public double u5Mult;
    public bool hasRun5;
    public double u5Power
    {
    
        get
        {
            return 150 * u5Level * u5Mult;
        }
    }

    public bool u5Auto;

#endregion
#region U6
           //upgrade6
    public double u6Cost
    {
        get
        {
        return 1000000 * System.Math.Pow(1.40, u6Level);
        }
    }
    public double u6Level;
    public float u6Timer;
    public float u6TimeCap;
    public double u6Mult;
    public bool hasRun6;
    public double u6Power
    {
    
        get
        {
            return 150 * u6Level * u6Mult;
        }
    }

    public bool u6Auto;
#endregion

    public Data()
    {
        FullReset();
    }

    public void FullReset()
    {
        Gold = 5;

        u1Level = 0;
        u1TimeCap = 1;
        u1Timer = 0;
        u1Mult = 1;
        u1Auto = false;

        u2Level = 0;     
        u2TimeCap = 4;
        u2Timer = 0;
        u2Mult = 1;
        u2Auto = false;
        
        u3TimeCap = 15;
        u3Timer = 0;
        u3Mult = 1;
        u3Level = 0;
        u3Auto = false;

        u4TimeCap = 30;
        u4Timer = 0;
        u4Mult = 1;
        u4Level = 0;
        u4Auto = false;

        u5TimeCap = 45;
        u5Timer = 0;
        u5Mult = 1;
        u5Level = 0;
        u5Auto = false;

        u6TimeCap = 60;
        u6Timer = 0;
        u6Mult = 1;
        u6Level = 0;
        u6Auto = false;
    }
    public void SavePlayer ()
    {
        SaveSystem.SaveGame(this);
    }
    public void LoadPlayer ()
    {
        GameData load = SaveSystem.LoadGame();
         Gold = load.gold;

         u1Level = load.u1Level;
         u1Mult = load.u1Mult;
         u1Auto = load.u1Auto;
         hasRun1 = load.hasRun1;

         u2Level = load.u2Level;
         u2Mult = load.u2Mult;
         u2Auto = load.u2Auto;
         hasRun1 = load.hasRun2;

         u3Level = load.u3Level;
         u3Mult = load.u3Mult;
         u3Auto = load.u3Auto;
         hasRun1 = load.hasRun3;

         u4Level = load.u4Level;
         u4Mult = load.u4Mult;
         u4Auto = load.u4Auto;
         hasRun1 = load.hasRun4;

         u5Level = load.u5Level;
         u5Mult = load.u5Mult;
         u5Auto = load.u5Auto;
         hasRun1 = load.hasRun5;

         u6Level = load.u6Level;
         u6Mult = load.u6Mult;
         u6Auto = load.u6Auto;
         hasRun1 = load.hasRun6;

    }
/*
    public void LoadSettings()
    {
        GameSettings load = SaveSystem.LoadGame();

        settingsMenu.SetVolume(load.volume);
        settingsMenu.SetFullScreen(load.isFullScreen);
        settingsMenu.SetQuality(load.qualityIndex);
    }
*/
}

public class GameController : MonoBehaviour
{
    public Animator anim;

    public CanvasController canvascontroller;
    public SoundEffects soundEffects;

    string[] animations = new string[] {"Attack", "HeroKnight_Attack2", "HeroKnight_Attack3"};

    public Data data;
    public TMP_Text goldText;

    public TMP_Text u1TitleText;
    public TMP_Text u1CostText;
    public TMP_Text u1ProductionText;
    public TMP_Text u1PercentText;
    public Image u1Fill;

    public TMP_Text u2TitleText;
    public TMP_Text u2CostText;
    public TMP_Text u2ProductionText;
    public TMP_Text u2PercentText;
    public Image u2Fill;

    public TMP_Text u3TitleText;
    public TMP_Text u3CostText;
    public TMP_Text u3ProductionText;
    public TMP_Text u3PercentText;
    public Image u3Fill;

    public TMP_Text u4TitleText;
    public TMP_Text u4CostText;
    public TMP_Text u4ProductionText;
    public TMP_Text u4PercentText;
    public Image u4Fill;

    public TMP_Text u5TitleText;
    public TMP_Text u5CostText;
    public TMP_Text u5ProductionText;
    public TMP_Text u5PercentText;
    public Image u5Fill;

    public TMP_Text u6TitleText;
    public TMP_Text u6CostText;
    public TMP_Text u6ProductionText;
    public TMP_Text u6PercentText;
    public Image u6Fill;
    

    public void RunUs()
    {
        RunU(1, "Kill Blue Slime", u1TitleText, u1CostText, u1ProductionText, u1PercentText, u1Fill, data.u1Level, data.u1Cost, data.u1Power, data.u1Mult, ref data.u1Timer, data.u1TimeCap, data.u1Auto);
        RunU(2, "Kill Sewer Rat", u2TitleText, u2CostText, u2ProductionText, u2PercentText, u2Fill, data.u2Level, data.u2Cost, data.u2Power, data.u2Mult, ref data.u2Timer, data.u2TimeCap, data.u2Auto);
        RunU(3, "Kill Scorpion", u3TitleText, u3CostText, u3ProductionText, u3PercentText, u3Fill, data.u3Level, data.u3Cost, data.u3Power, data.u3Mult, ref data.u3Timer, data.u3TimeCap, data.u3Auto);
        RunU(4, "Kill Giant Spider", u4TitleText, u4CostText, u4ProductionText, u4PercentText, u4Fill, data.u4Level, data.u4Cost, data.u4Power, data.u4Mult, ref data.u4Timer, data.u4TimeCap, data.u4Auto);
        RunU(5, "Kill Dark Wolf", u5TitleText, u5CostText, u5ProductionText, u5PercentText, u5Fill, data.u5Level, data.u5Cost, data.u5Power, data.u5Mult, ref data.u5Timer, data.u5TimeCap, data.u5Auto);
        RunU(6, "Kill Skeleton", u6TitleText, u6CostText, u6ProductionText, u6PercentText, u6Fill, data.u6Level, data.u6Cost, data.u6Power, data.u6Mult, ref data.u6Timer, data.u6TimeCap, data.u6Auto);
    }

    public void RunU( int id, string title, TMP_Text titleT, TMP_Text costT, TMP_Text prod, TMP_Text per, Image fill, double level, double cost, double power, double mult, ref float timer, float timeCap, bool auto)
    {
    titleT.text = title + " - LVL " + level;
    costT.text = "Buy\ncost: " + Notation(cost);
    prod.text = Notation(power) + " G/Fill";
    per.text = (timer / timeCap * 100).ToString("F0") + "%";
    fill.fillAmount = timer / timeCap;

        if(level != 0)
             if (timer < timeCap) timer += Time.deltaTime * (float)mult;
            else if (auto)
                CollectU(id);
            else
                timer = timeCap;
    }

    public void CollectU(int id)
    {
        switch (id)
        {
            case 1:
                Collect(ref data.u1Timer, data.u1TimeCap, data.u1Power);
            break;
            case 2:
                Collect(ref data.u2Timer, data.u2TimeCap, data.u2Power);
            break;
            case 3:
                Collect(ref data.u3Timer, data.u3TimeCap, data.u3Power);
            break;
            case 4:
                Collect(ref data.u4Timer, data.u4TimeCap, data.u4Power);
            break;
            case 5:
                Collect(ref data.u5Timer, data.u5TimeCap, data.u5Power);
            break;
            case 6:
                Collect(ref data.u6Timer, data.u6TimeCap, data.u6Power);
            break;
        }
    }

    public void Collect(ref float timer, float timeCap, double power)
    {
        if (timer >= timeCap)
        {
            data.Gold += power;
            timer = 0;

            anim.Play(animations[UnityEngine.Random.Range(0, 3)]);
        }
    }

    public void BuyU(int id)
    {
        switch(id)
        {
            case 1:
                Buy(data.u1Cost, ref data.u1Level, ref data.u1Mult, ref data.u1Auto);
                break;
            case 2:
                Buy(data.u2Cost, ref data.u2Level, ref data.u2Mult, ref data.u2Auto);
                break;
            case 3:
                Buy(data.u3Cost, ref data.u3Level, ref data.u3Mult, ref data.u3Auto);
                break;
            case 4:
                Buy(data.u4Cost, ref data.u4Level, ref data.u4Mult, ref data.u4Auto);
                break;
            case 5:
                Buy(data.u5Cost, ref data.u5Level, ref data.u5Mult, ref data.u5Auto);
                break;
            case 6:
                Buy(data.u6Cost, ref data.u6Level, ref data.u6Mult, ref data.u6Auto);
                break;
        }
    }
    public void Buy(double cost, ref double level, ref double mult, ref bool auto)
    {
        if (data.Gold >= cost)
        {
            data.Gold -= cost;
            level += 1;
                soundEffects.buy();
            if (level == 10)
                mult *= 2;
            if (level == 25)
                mult *= 2;
            else if (level % 50 == 0)
                mult *= 2;
            if (level == 100) auto = true;
        }
    }

    public void BuyMaxAll()
    {
        BuyMaxU(18750, 1.40, ref data.u6Level);
        BuyMaxU(18750, 1.35, ref data.u5Level);
        BuyMaxU(18750, 1.30, ref data.u4Level);
        BuyMaxU(18750, 1.25, ref data.u3Level);
        BuyMaxU(250, 1.20, ref data.u2Level);
        BuyMaxU(5, 1.15, ref data.u1Level);
    }

    public void BuyMaxU(double b, double r, ref double k)
    {
        var c = data.Gold;
        var n = System.Math.Floor(System.Math.Log(c * (r - 1) / (b * System.Math.Pow(r, k)) + 1, r));

        var cost = b * (System.Math.Pow(r, k) * (System.Math.Pow(r, n) -1) / (r - 1));

        if (data.Gold >= cost)
        {
            k += n;
            data.Gold -= cost;
            soundEffects.buy();
        }

    }

    public String Notation(double x)
    {
        string result = x.ToString("F2");
    if (x > 1000)
    {
        result = (x / 1000).ToString("F") + "K";
        return result;
    }
    else
            return result;
    }
   
    public void Save(){
        data.SavePlayer();
    }
    public void Load(){
        data.LoadPlayer();
    }
    public void SaveAndQuit()
    {
        data.SavePlayer();
        SceneManager.LoadScene("MainMenu");
    }

    public void BuyAuto1(){
        if(data.Gold >= 100 && data.u1Auto == false)
        {
        data.Gold -= 100;
        data.u1Auto = true;
        canvascontroller.autoBought1();
        soundEffects.buy();
        }
    }
    public void BuyAuto2(){
        if(data.Gold >= 800 && data.u2Auto == false)
        {
        data.Gold -= 800;
        data.u2Auto = true;
        canvascontroller.autoBought2();
        soundEffects.buy();
        }
    }
    public void BuyAuto3(){
        if(data.Gold >= 2000 && data.u3Auto == false)
        {
        data.Gold -= 2000;
        data.u3Auto = true;
        canvascontroller.autoBought3();
        soundEffects.buy();
        }
    }
    public void BuyAuto4(){
        if(data.Gold >= 5000 && data.u4Auto == false)
        {
        data.Gold -= 5000;
        data.u4Auto = true;
        canvascontroller.autoBought4();
        soundEffects.buy();
        }
    }
    public void BuyAuto5(){
        if(data.Gold >= 10000 && data.u5Auto == false)
        {
        data.Gold -= 10000;
        data.u5Auto = true;
        canvascontroller.autoBought5();
        soundEffects.buy();
        }
    }
    public void BuyAuto6(){
        if(data.Gold >= 30000 && data.u6Auto == false)
        {
        data.Gold -= 30000;
        data.u6Auto = true;
        canvascontroller.autoBought6();
        soundEffects.buy();
        }
    }


    public void Reset()
    {
        data.FullReset();
    }

    public float period = 0.0f;
    public void Update()
    {
        goldText.text = Notation(data.Gold) + " G";
        RunUs();

        if (period > 10.0f)
            {
                data.SavePlayer();
                Debug.Log("saved");
                period = 0;
            }
        period += UnityEngine.Time.deltaTime;
    }

}
