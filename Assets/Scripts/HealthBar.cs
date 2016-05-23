﻿using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;
using System.Collections;

public class HealthBar : MonoBehaviour
{
    public float hp = 100;
    public float currentHP;
    public Slider healthbar;

    private Player_Move playermove;
    private UnitAttributes health;
    private bool dead;
    private bool damaged = false;

    void Awake()
    {
        playermove = GetComponent<Player_Move>();
        health = GetComponent<UnitAttributes>();
    }

    public void takedamage(float amount)
    {
        damaged = true;
        currentHP -= amount;
        healthbar.value = currentHP;
        if (currentHP == 0 && !dead)
        {
            died();
        }
    }

    public void died()
    {
        dead = true;
    }

    void Update()
    {
        if(CompareTag("UI"))
           takedamage(currentHP);
    }
}