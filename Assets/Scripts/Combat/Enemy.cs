using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Enemy : MonoBehaviour
{
    public PlayerAttack attackInfo;
    public Type characterType;
    public int maxHealth;
    public int currentHealth;
    public GameObject attackDisplay;
    public Text hpDisplay;
    public Text typeDisplay;

    private void Start()
    {
        currentHealth = maxHealth;
    }

    private void OnMouseDown()
    {
        if(!attackDisplay.activeInHierarchy)
        {
            attackDisplay.SetActive(true);
        }
        attackInfo.currentEnemy = this;
        hpDisplay.text = currentHealth.ToString();
        typeDisplay.text = characterType.ToString();
    }
}
