using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using EnemyValues;
using UnityEngine.UI;

public class EnemyHealthBar : MonoBehaviour
{
    public GameObject EnemySlider;
    public Enemy enemy;
    // Start is called before the first frame update
    public void Start()
    {
        GetComponent<Slider>().value = enemy.EnemyHealth;
    }

    // Update is called once per frame
    void Update()
    {
        GetComponent<Slider>().value = enemy.EnemyHealth;
    }
}
