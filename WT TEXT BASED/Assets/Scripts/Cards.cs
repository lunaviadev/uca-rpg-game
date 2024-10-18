using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using CardsManagement;
using PlayerValues;
using EnemyValues;

namespace CardsList
{

    public class Cards : MonoBehaviour
    {
        public int skillPointsRequired;
        public int skillPointsCheck;
        public ClassData player;
        public Enemy enemy;

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
            }
            else
            {
                Debug.Log("Enemy is null!");
                enemy = GameObject.Find("Enemy").GetComponent<Enemy>();
                enemy.takeDamage(enemy.EnemyDefence);
            }
        }

        public void HeavyAttack()
        {
            HeavyAttackCard();
            player.doDamage(player.attack);
        }

        public void Defend()
        {
            DefendCard();
        }
    }

}