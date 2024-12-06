using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using CardsManagement;
using PlayerValues;
using EnemyValues;
using CardShuffle;

namespace CardsList
{

    public class Cards : MonoBehaviour
    {
        public int skillPointsRequired;
        public int skillPointsCheck;
        public ClassData player;
        public Enemy enemy;

        private TurnScript TurnScript;
        private ShuffleHand HandScript;

        private void Awake()
        {
            TurnScript = GameObject.FindGameObjectWithTag("Manager").GetComponent<TurnScript>();
            player = TurnScript.Player;
            enemy = TurnScript.Enemy;
            HandScript = GameObject.FindGameObjectWithTag("Player").GetComponent<ShuffleHand>();
        }

        public bool checkSkillPoints()
        {
            if (player.skillPoints >= skillPointsRequired)
            {
                return true;
            }
            else return false;

        }
        public bool BasicAttackCard()
        {
            skillPointsRequired = 1;
            if (checkSkillPoints())
            {
                player.skillPoints = player.skillPoints - 1;
                Debug.Log("Successful Basic Attack");
                return true;
            }
            else Debug.Log("Invalid Input"); return false;
        }

        public bool HeavyAttackCard()
        {
            skillPointsRequired = 2;
            if (checkSkillPoints())
            {
                player.skillPoints = player.skillPoints - 2;
                Debug.Log("Successful Heavy Attack");
                return true;
            }
            else Debug.Log("Invalid Input"); return false;
        }

        public bool HealCard()
        {
            skillPointsRequired = 1;
            if (checkSkillPoints())
            {
                player.skillPoints = player.skillPoints - 1;
                return true;
            }
            else return false;
        }

        public bool HeavyHealCard()
        {
            skillPointsRequired = 2;
            if (checkSkillPoints())
            {
                player.skillPoints = player.skillPoints - 2;
                return true;
            }
            else return false;
        }
        public bool DefendCard()
        {
            skillPointsRequired = 0;
            if (checkSkillPoints())
            {
                Debug.Log("Successful Defend");
                return true;
            }
            else Debug.Log("Invalid Input"); return false;
        }

        public void BasicAttack()
        {
            BasicAttackCard();
            Debug.Log(player.playerName);
            if (enemy != null)
            {
                Debug.Log(enemy.EnemyName);
                enemy.takeDamage(enemy.EnemyDefence);
                TurnScript.PlayerGone = true;
                TurnScript.Combat();
                HandScript.DestroyHand();
            }
            else
            {
                Debug.Log("Enemy is null!");
                enemy = GameObject.Find("Enemy").GetComponent<Enemy>();
                enemy.takeDamage(enemy.EnemyDefence);
                HandScript.DestroyHand();
            }

        }

        public void HeavyAttack()
        {
            HeavyAttackCard();
            Debug.Log(player.playerName);
            if (enemy != null)
            {
                Debug.Log(enemy.EnemyName);
                enemy.takeDamage(enemy.EnemyDefence);
                HandScript.DestroyHand();
            }
            else
            {
                Debug.Log("Enemy is null!");
                enemy = GameObject.Find("Enemy").GetComponent<Enemy>();
                enemy.takeDamage(enemy.EnemyDefence);
                HandScript.DestroyHand();
            }
        }

        public void Heal()
        {
            HealCard();
            player.health += Random.Range(15, 60);
            HandScript.DestroyHand();
        }

        public void HeavyHeal()
        {
            HeavyHealCard();
            player.health += Random.Range(30, 90);
            HandScript.DestroyHand();
        }

        public void Defend()
        {
            DefendCard();
            HandScript.DestroyHand();
        }
    }

}