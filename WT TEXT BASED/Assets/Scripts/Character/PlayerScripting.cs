using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Player;
using Dice;

public class PlayerScripting : MonoBehaviour
{
    public string PlayerName = "Barbarian";
    public int PlayerDamage, PlayerHealth, PlayerDefence;
    public DiceManager diceManager;
    public List<int> acceptableDiceSides;
    public int damageHitCalculator(int rawDamage)
    {
        int rawDamage = PlayerDamage * diceRollResult - EnemyDefence;
    }

    public int damageTakenCalculator(int damageRecieved)
    { 
        int damageRecieved = enemy.damage - PlayerDefence;
        return damageRecieved;
    }
}
