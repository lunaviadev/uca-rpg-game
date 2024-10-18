using Classes;
using Dice;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using EnemyTyping;

namespace EnemyValues

{

    public class Enemy : MonoBehaviour
    {
        public int EnemyHealth = 100;
        public int EnemyAttack, EnemyDefence, EnemyMDef, EnemyMAttack, EnemyAgility, EnemyLuck;
        public float EnemyCritChance = 2.5f;
        public bool isDead = false;
        public EnemyManager typing;
    }
}