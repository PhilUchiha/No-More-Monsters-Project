using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class GameData
{    
    public double gold;
    public double gems;


    public double u1Level;
    public double u1Mult;
    public bool u1Auto;
    public bool hasRun1;

    public double u2Level;
    public double u2Mult;
    public bool u2Auto;
    public bool hasRun2;

    public double u3Level;
    public double u3Mult;
    public bool u3Auto;
    public bool hasRun3;

    public double u4Level;
    public double u4Mult;
    public bool u4Auto;
    public bool hasRun4;

    public double u5Level;
    public double u5Mult;
    public bool u5Auto;
    public bool hasRun5;

    public double u6Level;
    public double u6Mult;
    public bool u6Auto;
    public bool hasRun6;
/*
#region settings

    public bool isFullScreen;
    public float volume;
    public int qualityIndex;

#endregion
*/
    public GameData (Data game)
    {
        gold = game.Gold;
        gems = game.Gems;

        u1Level = game.u1Level;
        u1Mult = game.u1Mult;
        u1Auto = game.u1Auto;
        hasRun1 = game.hasRun1;

        u2Level = game.u2Level;
        u2Mult = game.u2Mult;
        u2Auto = game.u2Auto;
        hasRun2 = game.hasRun2;

        u3Level = game.u3Level;
        u3Mult = game.u3Mult;
        u3Auto = game.u3Auto;
        hasRun3 = game.hasRun3;

        u4Level = game.u4Level;
        u4Mult = game.u4Mult;
        u4Auto = game.u4Auto;
        hasRun4 = game.hasRun4;

        u5Level = game.u5Level;
        u5Mult = game.u5Mult;
        u5Auto = game.u5Auto;
        hasRun5 = game.hasRun5;
        
        u6Level = game.u6Level;
        u6Mult = game.u6Mult;
        u6Auto = game.u6Auto;
        hasRun6 = game.hasRun6;

    }
/*
    public GameSettings (settingsMenu settings)
    {
        isFullScreen = settingsMenu.isFullScreen;
        volume = settingsMenu.volume;
        qualityIndex = settingsMenu.qualityIndex;
    }
*/

}
