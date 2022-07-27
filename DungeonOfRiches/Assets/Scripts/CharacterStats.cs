using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterStats : MonoBehaviour
{
    //Stats
    public int ID;
    public float Health;
    public float Mana;
    public float Strength;
    public float Intelligence;
    public float AtackSpeed;
    public float AtackRange;
    public float MoveSpeed;
    public float AbilityHaste;
    public float CritChance;
    public float Luck;
    public float Armor;
    public float FireRes;
    public float IceRes;
    public float LightingRes;
    public float ToxicRes;
    public float ArmorPen;

    public bool Imortal;

    void Start()
    {
        SetToBaseStats(ID);
    }

    void Update()
    {
        if (Health >= 0 && !Imortal) 
        {
            Destroy(gameObject);
        }
    }

    void SetToBaseStats(int id) 
    {
        Health = BaseCharacterStats.Stats[id, 0];
        Mana = BaseCharacterStats.Stats[id, 1];
        Strength = BaseCharacterStats.Stats[id, 2];
        Intelligence = BaseCharacterStats.Stats[id, 3];
        AtackSpeed = BaseCharacterStats.Stats[id, 4];
        AtackRange = BaseCharacterStats.Stats[id, 5];
        MoveSpeed = BaseCharacterStats.Stats[id, 6];
        AbilityHaste = BaseCharacterStats.Stats[id, 7];
        CritChance = BaseCharacterStats.Stats[id, 8];
        Luck = BaseCharacterStats.Stats[id, 9];
        Armor = BaseCharacterStats.Stats[id, 10];
        FireRes = BaseCharacterStats.Stats[id, 11];
        IceRes = BaseCharacterStats.Stats[id, 12];
        LightingRes = BaseCharacterStats.Stats[id, 13];
        ToxicRes = BaseCharacterStats.Stats[id, 14];
        ArmorPen = BaseCharacterStats.Stats[id, 15];
    }
}
