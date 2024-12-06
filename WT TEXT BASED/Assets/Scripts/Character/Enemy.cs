using Classes;
using Dice;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using EnemyTyping;
using PlayerValues;
using CardShuffle;
using UnityEngine.UI;
using UnityEditor;
using UnityEngine.SceneManagement;

namespace EnemyValues

{

    public class Enemy : MonoBehaviour
    {
        public int EnemyHealth = 100;
        public string EnemyName;
        public int EnemyAttack, EnemyDefence, EnemyMDef, EnemyMAttack, EnemyAgility, EnemyLuck ;
        public float EnemyCritChance = 2.5f;
        public bool isDead = false;
        public EnemyManager typing;
        public ClassData player;
        public int agility;
        private TurnScript TurnScript;
        private ShuffleHand HandScript;
        public Button replayButton;

        private void Start()
        {
            TurnScript = GameObject.FindGameObjectWithTag("Manager").GetComponent<TurnScript>();
            EnemyAttack = Random.Range(1, 10);
            EnemyDefence = Random.Range(1, 10);
            EnemyMDef = Random.Range(1, 10);
            EnemyMAttack = Random.Range(1, 10);
            EnemyAgility = Random.Range(1, 10);
            EnemyLuck = Random.Range(1, 10);
            agility = Random.Range(1, 9);
            HandScript = GameObject.FindGameObjectWithTag("Player").GetComponent<ShuffleHand>();
        }

        public void takeDamage(int Defence)
        {
            int incomingDamage = player.attack * 2 - EnemyDefence;
            if(incomingDamage < 0)
            {
                incomingDamage = 0;
            }
            EnemyHealth = EnemyHealth - incomingDamage;
        }

        public void doDamage(int attack)
        {
            int outgoingDamage = attack * 2;
            player.takeDamage(outgoingDamage);
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
                SceneManager.LoadScene("Game Over");
            }

        }
    }

}