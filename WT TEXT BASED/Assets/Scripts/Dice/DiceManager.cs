using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

namespace Dice
{
    public class DiceManager : MonoBehaviour
    {
        public int Roll(int sides)
        {
            int diceRollResult = Random.Range(1, sides + 1);

            Debug.Log("Dice was rolled, results are:" + diceRollResult);
            CritCheck(diceRollResult, sides);
            return diceRollResult;
        }

        public bool CritCheck(int value, int critValue)
        {
            if (value == critValue)
            {
                Debug.Log("Critical Hit!");
                return true;
            }
            return false;
        }

    }
}


