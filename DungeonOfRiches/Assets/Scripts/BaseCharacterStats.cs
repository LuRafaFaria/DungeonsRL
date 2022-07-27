using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class BaseCharacterStats
{
    /*
     0 Test Character
     1 
     */
    static public float[,] Stats  = 
    {
        /*
        0 Health
        1 Mana
        2 Strength
        3 Intelligence
        4 AtackSpeed
        5 AtackRange
        6 MoveSpeed
        7 Ability Haste
        8 Crit Chance
        9 Luck
        10 Armor
        11 Fire Res
        12 Ice Res
        13 Lighting Res
        14 Toxic Res
        15 Armor Pen
        */
        { 
            0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 //ID = 0
        }
        ,
        {
            100f,
            100f,
            10f,
            10f,
            0.5f,
            5f,
            2,
            0,
            0,
            1,
            10,
            0,
            0,
            0,
            0,
            0
        } 
    };
}
