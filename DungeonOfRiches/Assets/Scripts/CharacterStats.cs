using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterStats : MonoBehaviour
{
    //Stats
    public int ID;
    public float CharType;
    public float Health;
    public float Mana;
    public float Strength;
    public float Intelligence;
    public float AttackSpeed;
    public float AttackRange;
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

    public float CurrentHealth;
    public float CurrentMana;
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

    public void SetToBaseStats(int id) 
    {
        CharType = BaseCharacterStats.Stats[id, 0];
        Health = BaseCharacterStats.Stats[id, 1];
        Mana = BaseCharacterStats.Stats[id, 2];
        Strength = BaseCharacterStats.Stats[id, 3];
        Intelligence = BaseCharacterStats.Stats[id, 4];
        AttackSpeed = BaseCharacterStats.Stats[id, 5];
        AttackRange = BaseCharacterStats.Stats[id, 6];
        MoveSpeed = BaseCharacterStats.Stats[id, 7];
        AbilityHaste = BaseCharacterStats.Stats[id, 8];
        CritChance = BaseCharacterStats.Stats[id, 9];
        Luck = BaseCharacterStats.Stats[id, 10];
        Armor = BaseCharacterStats.Stats[id, 11];
        FireRes = BaseCharacterStats.Stats[id, 12];
        IceRes = BaseCharacterStats.Stats[id, 13];
        LightingRes = BaseCharacterStats.Stats[id, 14];
        ToxicRes = BaseCharacterStats.Stats[id, 15];
        ArmorPen = BaseCharacterStats.Stats[id, 166];
    }
    public float Attacked(float DMG, float TypeDMG, float APEN) 
    {
        float FinalDamage = DMG * (100 / (100 + (Armor - APEN)));
        CurrentHealth -= FinalDamage;
        return FinalDamage;
    }
}
