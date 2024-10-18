using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Dice;
using Classes;
using EnemyValues;
using Unity.VisualScripting;

namespace PlayerValues
{
    public class ClassData : MonoBehaviour
    {
        public int health, attack, defence, mDef, mAttack, agility, luck, skillPoints;
        public string playerName;
        public float critChance = 2.5f;
        public string selectedClass; 
        public bool isDead = false;
        public DiceManager diceManager;
        public Enemy enemy;
        public ClassManager classes; 
        public List<int> cardList;
        public List<int> acceptableDice;

        public void Start()
        {
            if (selectedClass == "Archer")
            {
                attack += 3;
                defence += 2;
                mDef += 1;
                mAttack += 2;
                agility += 5;
                luck += 2;
            }

            else if (selectedClass == "Paladin")
            {
                attack += 5;
                defence += 4;
                mDef += 2;
                mAttack -= 1;
                agility -= 1;
                luck += 1;
            }

            else if (selectedClass == "Knight")
            {
                attack += 2;
                defence += 2;
                mDef += 2;
                mAttack += 1;
                agility += 2;
                luck += 2;
            }

            else if (selectedClass == "Thief")
            {
                attack += 3;
                defence -= 1;
                mDef -= 1;
                mAttack += 3;
                agility += 5;
                luck += 4;
            }

            else if (selectedClass == "Vagrant")
            {
                attack -= 1;
                defence -= 1;
                mDef -= 1;
                mAttack -= 1;
                agility -= 1;
                luck -= 1;
            }
        }

        public void takeDamage(int EnemyAttack)
        {
            int incomingDamage = enemy.EnemyAttack * 2 - defence;
            health = health - incomingDamage;
        }

        public void doDamage(int attack)
        {
            int outgoingDamage = diceManager.Roll(20) * attack; 
        }

        public void Update()
        {
           
        }

    }

    



}

