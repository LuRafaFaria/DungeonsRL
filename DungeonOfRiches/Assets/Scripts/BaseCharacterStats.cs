using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class BaseCharacterStats
{
    static public float[,] Stats  = 
    {
        /*
        0 CharacterType // 0 = PartyMember, 1.0 = BasicEnemy 1.1 = LargeEnemy , 2 = NPC
        1 Health
        2 Mana
        3 Strength
        4 Intelligence
        5 AttackSpeed
        6 AttackRange
        7 MoveSpeed
        8 Ability Haste
        9 Crit Chance
        10 Luck
        11 Armor
        12 Fire Res
        13 Ice Res
        14 Lighting Res
        15 Toxic Res
        16 Armor Pen
        */
        //ID = 0
        {
            0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 
        }
        ,
        //PartyMemberTest
        {
            0,
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
        ,
        //EnemyTest
        {
            1,
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
