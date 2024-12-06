using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Dice;
using Classes;
using EnemyValues;
using Unity.VisualScripting;
using CardShuffle;
using UnityEngine.SceneManagement;

namespace PlayerValues
{
    public class ClassData : MonoBehaviour
    {
        public int health = 100, attack, defence, mDef , mAttack, agility , luck, skillPoints;
        public string playerName;
        public float critChance = 2.5f;
        public string selectedClass; 
        public bool isDead = false;
        public DiceManager diceManager;
        public Enemy enemy;
        public ClassManager classes; 
        public List<int> cardList;
        public List<int> acceptableDice;
        [SerializeField]private TurnScript TurnScript;
        private ShuffleHand HandScript;


        private void Start()
        {
            TurnScript = GameObject.FindGameObjectWithTag("Manager").GetComponent<TurnScript>();
            attack = Random.Range(1, 10);
            defence = Random.Range(1, 10);
            mDef = Random.Range(1, 10);
            mAttack = Random.Range(1, 10);
            agility = Random.Range(1, 10);
            luck = Random.Range(1, 10);
            agility = Random.Range(1, 9);
            HandScript = GameObject.FindGameObjectWithTag("Player").GetComponent<ShuffleHand>();
        }

        public void takeDamage(int EnemyAttack)
        {
            Debug.Log("TAken Damage");
            int incomingDamage = EnemyAttack * 2 - defence;
            health = health - incomingDamage;
            TurnScript.PlayerGone = false;
            TurnScript.Combat();
            HandScript.DestroyHand();

        }

        public void doDamage(int attack)
        {
            int outgoingDamage = diceManager.Roll(20) * attack; 
        }

        public void Update()
        {
            if (health == 0)
            {
          
             SceneManager.LoadScene("Game Over");
               
            }
        }

        

    }

    



}

