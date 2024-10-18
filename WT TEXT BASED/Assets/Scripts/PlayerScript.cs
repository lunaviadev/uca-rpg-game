using EnemyValues;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using PlayerValues;
using TMPro;

public class PlayerScript : MonoBehaviour
{
    public GameObject PlayerSlider;
    public ClassData player;
    public GameObject PlayerNumberHealth;
    public void Start()
    {
        GetComponent<Slider>().value = player.health;
    }

    // Update is called once per frame
    /*void Update()
    {
        GetComponent<Slider>().value = player.health;
        GetComponent<TMP_Text>().text = "";
    }
    */
}
