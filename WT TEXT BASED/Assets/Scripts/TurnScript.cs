using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using PlayerValues;
using EnemyValues;
using CardShuffle;

public class TurnScript : MonoBehaviour
{
    public ClassData Player;
    public Enemy Enemy;
    public ShuffleHand Cards;
    private bool playerFirst;
    public bool PlayerGone;
    public bool RegisterBattle()
    {
        if (Player.isDead == true) return false;

        bool isPlayerFirst = Player.agility >= Enemy.agility ? true : false;
        return isPlayerFirst;

    }

    public void StartCombat()
    {
        playerFirst = RegisterBattle();

        PlayerGone = playerFirst;
        Combat();
    }

    public void Combat()
    {
        if (PlayerGone == true)
        {
            Player.health -= Random.Range(1, 50);
            PlayerGone = false;
            Combat();
            Debug.Log("NOT NEW TURN");
        }
        else
        {
            Cards.StartTurn();
            Debug.Log("NEW TURN");
        }
    }

    private void Start()
    {
        StartCombat();
    }
}
