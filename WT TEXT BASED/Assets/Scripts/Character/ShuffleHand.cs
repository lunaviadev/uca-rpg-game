using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using PlayerValues;
using CardsList;

namespace CardShuffle
{

    public class ShuffleHand : MonoBehaviour
    {
        [SerializeField] private GameObject[] CardTypes;
        [SerializeField] private RectTransform[] CardTransform;
        private GameObject[] TempCards = new GameObject[3];
        private TurnScript TurnScript;

        private void Start()
        {
            TurnScript = GameObject.FindGameObjectWithTag("Manager").GetComponent<TurnScript>();
        }
        public void StartTurn()
        {
            TempCards = new GameObject[3];
            int i = 0;
            foreach (RectTransform r in CardTransform)
            {
                TempCards[i] = Instantiate(CardTypes[Random.Range(1, 5)]);
                TempCards[i].transform.position = CardTransform[i].position;
                TempCards[i].transform.parent = CardTransform[i].transform;
                i++;
            }
        }

        public void DestroyHand()
        {
            int i = 0;
            foreach (GameObject g in TempCards)
            {
                Destroy(TempCards[i]);
                i++;
            }
            TurnScript.PlayerGone = true;
            TurnScript.Combat();
        }

    }

    
}
