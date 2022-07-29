using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class AttackStats
{
    static public float[,] Stats =
    {
        /*
         0 AttackType // 0 = Targeted, 1 = Skillshot, 2 = AOE
         1 DamageType //0 = true 1 = Physical, 2 = Fire, 3 = Ice, 4 = Lighting, 5 = Toxic
         2 Damage
         3 Health Scaling
         4 Current Health Scaling
         5 Mana Scaling
         6 Current Mana Scaling
         7 Strength Scaling
         8 Intelligence Scaling
         9 AttackSpeed Scaling
         10 AttackRange Scaling
         11 MoveSpeed Scaling
         12 Ability Haste Scaling
         13 Crit Chance Scaling
         14 Luck Scaling
         15 Armor Scaling
         16 Fire Res Scaling
         17 Ice Res Scaling
         18 Lighting Res Scaling
         19 Toxic Res Scaling
         20 Armor Pen Scaling
         21 EnemyScalingStat //Selects the stat that will scale on the enemy
         22 EnemyScaling
         */
        //TestAttack
        {
            0,1,10,0,0,0,0,0.5f,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0
        }
    };
}
