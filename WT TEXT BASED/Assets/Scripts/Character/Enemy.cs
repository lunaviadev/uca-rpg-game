using Classes;
using Dice;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using EnemyTyping;
using PlayerValues;

namespace EnemyValues

{

    public class Enemy : MonoBehaviour
    {
        public int EnemyHealth = 100;
        public string EnemyName;
        public int EnemyAttack, EnemyDefence, EnemyMDef, EnemyMAttack, EnemyAgility, EnemyLuck;
        public float EnemyCritChance = 2.5f;
        public bool isDead = false;
        public EnemyManager typing;
        public ClassData player;

        public void takeDamage(int Defence)
        {
            int incomingDamage = player.attack * 2 - EnemyDefence;
            EnemyHealth = EnemyHealth - incomingDamage;
        }

        public void doDamage(int attack)
        {
            int outgoingDamage = attack * 2;
        }

        public void Update()
        {
            if (EnemyHealth <= 0)
            {
                isDead = true;
                return;
            }

            if (isDead == true)
            { 
                
            }
        }
    }

}