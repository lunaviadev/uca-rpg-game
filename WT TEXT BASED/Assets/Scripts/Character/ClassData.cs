using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Dice;

namespace Player
{
    public class ClassData : MonoBehaviour
    {
        public string name;
        public int damage, health;
        public DiceManager diceManager;
        public List<int> acceptableDiceSides;

    }
}

