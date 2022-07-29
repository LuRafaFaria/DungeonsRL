using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attack : MonoBehaviour
{
    public int ID;
    public GameObject Sender;
    public CharacterStats SenderStats;
    public int Target;
    float FinalDamage;
    public float ReducedDamage;

    public float AttackType; // 0 = Targeted, 1 = Skillshot, 2 = AOE
    public float DamageType; //0 = true 1 = Physical, 2 = Fire, 3 = Ice, 4 = Lighting, 5 = Toxic
    public float Damage;
    public float HealthScaling;
    public float CurrentHealthScaling;
    public float ManaScaling;
    public float CurrentManaScaling;
    public float StrengthScaling;
    public float IntelligenceScaling;
    public float AttackSpeedScaling;
    public float AttackRangeScaling;
    public float MoveSpeedScaling;
    public float AbilityHasteScaling;
    public float CritChanceScaling;
    public float LuckScaling;
    public float ArmorScaling;
    public float FireResScaling;
    public float IceResScaling;
    public float LightingResScaling;
    public float ToxicResScaling;
    public float ArmorPenScaling;
    public float EnemyScalingStat; //Selects the stat that will scale on the enemy
    public float EnemyScaling;

    private void OnTriggerEnter(Collider col)
    {
        if (col.tag == "Enemy" && Target == 1) 
        {
            FinalDamage = 0;
            FinalDamage += Damage;
            FinalDamage += SenderStats.Health * HealthScaling;
            FinalDamage += SenderStats.CurrentHealth * CurrentHealthScaling;
            FinalDamage += SenderStats.Mana * ManaScaling;
            FinalDamage += SenderStats.CurrentMana * CurrentManaScaling;
            FinalDamage += SenderStats.Strength * StrengthScaling;
            FinalDamage += SenderStats.Intelligence * IntelligenceScaling;
            FinalDamage += SenderStats.AttackSpeed * AttackSpeedScaling;
            FinalDamage += SenderStats.AttackRange * AttackRangeScaling;
            FinalDamage += SenderStats.MoveSpeed * MoveSpeedScaling;
            FinalDamage += SenderStats.AbilityHaste * AbilityHasteScaling;
            FinalDamage += SenderStats.CritChance * CritChanceScaling;
            FinalDamage += SenderStats.Luck * LuckScaling;
            FinalDamage += SenderStats.Armor * ArmorScaling;
            FinalDamage += SenderStats.FireRes * FireResScaling;
            FinalDamage += SenderStats.IceRes * IceResScaling;
            FinalDamage += SenderStats.LightingRes * LightingResScaling;
            FinalDamage += SenderStats.ToxicRes * ToxicResScaling;
            FinalDamage += SenderStats.ArmorPen * ArmorPenScaling;
            if (EnemyScalingStat == 0)  {FinalDamage += col.gameObject.GetComponent<CharacterStats>().Health * EnemyScalingStat;}
            else if(EnemyScalingStat == 1)  {FinalDamage += col.gameObject.GetComponent<CharacterStats>().CurrentHealth * EnemyScalingStat;}
            else if (EnemyScalingStat == 2) {FinalDamage += col.gameObject.GetComponent<CharacterStats>().Mana * EnemyScalingStat;}
            else if (EnemyScalingStat == 3) {FinalDamage += col.gameObject.GetComponent<CharacterStats>().CurrentMana * EnemyScalingStat;}
            else if (EnemyScalingStat == 4) {FinalDamage += col.gameObject.GetComponent<CharacterStats>().Strength * EnemyScalingStat;}
            else if (EnemyScalingStat == 5) {FinalDamage += col.gameObject.GetComponent<CharacterStats>().Intelligence * EnemyScalingStat;}
            else if (EnemyScalingStat == 6) {FinalDamage += col.gameObject.GetComponent<CharacterStats>().AttackSpeed * EnemyScalingStat;}
            else if (EnemyScalingStat == 7) { FinalDamage += col.gameObject.GetComponent<CharacterStats>().AttackRange * EnemyScalingStat; }
            else if (EnemyScalingStat == 8) { FinalDamage += col.gameObject.GetComponent<CharacterStats>().MoveSpeed * EnemyScalingStat; }
            else if (EnemyScalingStat == 9) { FinalDamage += col.gameObject.GetComponent<CharacterStats>().AbilityHaste * EnemyScalingStat; }
            else if (EnemyScalingStat == 10) { FinalDamage += col.gameObject.GetComponent<CharacterStats>().CritChance * EnemyScalingStat; }
            else if (EnemyScalingStat == 11) { FinalDamage += col.gameObject.GetComponent<CharacterStats>().Luck * EnemyScalingStat; }
            else if (EnemyScalingStat == 12) { FinalDamage += col.gameObject.GetComponent<CharacterStats>().Armor * EnemyScalingStat; }
            else if (EnemyScalingStat == 13) { FinalDamage += col.gameObject.GetComponent<CharacterStats>().FireRes * EnemyScalingStat; }
            else if (EnemyScalingStat == 14) { FinalDamage += col.gameObject.GetComponent<CharacterStats>().IceRes * EnemyScalingStat; }
            else if (EnemyScalingStat == 15) { FinalDamage += col.gameObject.GetComponent<CharacterStats>().LightingRes * EnemyScalingStat; }
            else if (EnemyScalingStat == 16) { FinalDamage += col.gameObject.GetComponent<CharacterStats>().ToxicRes * EnemyScalingStat; }
            else if (EnemyScalingStat == 17) { FinalDamage += col.gameObject.GetComponent<CharacterStats>().ArmorPen * EnemyScalingStat; }

            float ArmorIgnored = col.gameObject.GetComponent<CharacterStats>().Armor * SenderStats.ArmorPen;

            ReducedDamage = col.gameObject.GetComponent<CharacterStats>().Attacked(FinalDamage, DamageType, ArmorIgnored);

            print(ReducedDamage);
            Destroy(gameObject);

        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void UpdateStats(int ID)
    {
        AttackType = AttackStats.Stats[ID,0];
        DamageType = AttackStats.Stats[ID, 1];
        Damage = AttackStats.Stats[ID, 2];
        HealthScaling = AttackStats.Stats[ID, 3];
        CurrentHealthScaling = AttackStats.Stats[ID, 4];
        ManaScaling = AttackStats.Stats[ID, 5];
        CurrentManaScaling = AttackStats.Stats[ID, 6];
        StrengthScaling = AttackStats.Stats[ID, 7];
        IntelligenceScaling = AttackStats.Stats[ID, 8];
        AttackSpeedScaling = AttackStats.Stats[ID, 9];
        AttackRangeScaling = AttackStats.Stats[ID, 10];
        MoveSpeedScaling = AttackStats.Stats[ID, 11];
        AbilityHasteScaling = AttackStats.Stats[ID, 12];
        CritChanceScaling = AttackStats.Stats[ID, 13];
        LuckScaling = AttackStats.Stats[ID, 14];
        ArmorScaling = AttackStats.Stats[ID, 15];
        FireResScaling = AttackStats.Stats[ID, 16];
        IceResScaling = AttackStats.Stats[ID, 17];
        LightingResScaling = AttackStats.Stats[ID, 18];
        ToxicResScaling = AttackStats.Stats[ID, 19];
        ArmorPenScaling = AttackStats.Stats[ID, 20];
        EnemyScalingStat = AttackStats.Stats[ID, 21];
        EnemyScaling = AttackStats.Stats[ID, 22];
}
}
