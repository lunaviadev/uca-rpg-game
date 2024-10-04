using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dice : MonoBehaviour
{
    public void Start()
    {
        RollD6();
        RollD12();
        RollD20();
    }
    public void RollD6()
    { 
        int diceRollResult = Random.Range(1,7);
        Debug.Log("Dice 6 was rolled, results are:" + diceRollResult);
    }
    public void RollD12()
    {
        int diceRollResult = Random.Range(1, 13);
        Debug.Log("Dice 6 was rolled, results are:" + diceRollResult);
    }

    public void RollD20()
    {
        int diceRollResult = Random.Range(1, 21);
        Debug.Log("Dice 6 was rolled, results are:" + diceRollResult);
    }


}
