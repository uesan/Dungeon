using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum Kind_of_damage{
    AD,AP,True
}

public class Actor : MonoBehaviour
{
    protected int health;
    protected int attack_damage;
    protected int abilty_power;
    protected int armor;
    protected int magic_resist;
    protected int level;

    public Actor()
    {
        health = 100;
        attack_damage = 10;
        abilty_power = 20;
        armor = 30;
        magic_resist = 25;
        level = 1;
    }

    public int DealDamage()
    {
        return DealDamageImp(attack_damage);
    }
    private int DealDamageImp(int attack_value)
    {
        return attack_value;
    }

    public void TakeDamage(int damage, Kind_of_damage kind_of_damage)
    {
        if (kind_of_damage == Kind_of_damage.AD)
        {
            TakeDamageImp(damage, armor);
        }else if (kind_of_damage == Kind_of_damage.AP)
        {
            TakeDamageImp(damage, magic_resist);
        }else
        {
            TakeDamageImp(damage, 0);
        }
    }

    private void TakeDamageImp(int damage, int defence_value)
    {
        float actual_damage;
        if (defence_value == 0)
            actual_damage = damage;
        else
            actual_damage = (float)damage * 100 / (defence_value + 100);
        health -= (int)actual_damage;
        Debug.Log(actual_damage);
        Debug.Log(health);

    }

    // Start is called before the first frame update
    void Start()
    {
        TakeDamage(10, Kind_of_damage.AD);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
