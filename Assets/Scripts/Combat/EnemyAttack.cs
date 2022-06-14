using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class EnemyAttack : MonoBehaviour
{
	public Enemy[] enemies = new Enemy[3];
	public Character[] players = new Character[3];
	private int[] hpPercentages = new int[3];
	public bool playerTurn;
	private int enemyTarget;
	private int lowestHP = 100;
	public int enemyDamage = 40;
	public GameObject winPanel;
	public Text alienWin;
	public Text humanWin;

	public void Target() // Determines who to target
	{
		if (enemies[0].currentHealth <= 0 & enemies[1].currentHealth <= 0 & enemies[2].currentHealth <= 0)
		{
			print("Humans win!");
			winPanel.SetActive(true);
			humanWin.gameObject.SetActive(true);
		}
		for (int i = 0; i < players.Length; i++) 
		{
			players[i].hasAttacked = false;
			hpPercentages[i] = (players[i].currentHealth / players[i].maxHealth) * 100;
			if(hpPercentages[i] < lowestHP)
			{
				lowestHP = hpPercentages[i];
				enemyTarget = i;
			}
		}
        if (lowestHP == 100)
        {
			enemyTarget = Random.Range(0, 3);
        }
        while (players[enemyTarget].currentHealth <= 0)
        {
			enemyTarget = Random.Range(0, 3);
            if (players[0].currentHealth <= 0 & players[1].currentHealth <= 0 & players[2].currentHealth <= 0)
            {
				print("Aliens win!");
				winPanel.SetActive(true);
				alienWin.gameObject.SetActive(true);
				break;
            }
        }
		print(enemyTarget);
		//return enemyTarget;
		AttackPhase();
	}

	public void AttackPhase() // Checks for advantage/disadvantage
	{
		foreach(Enemy t in enemies)
		{
            if (t.currentHealth > 0)
            {
				if (players[enemyTarget].characterType == Type.Magic)
				{
					if (t.characterType == Type.Melee)
					{
						enemyDamage = Mathf.RoundToInt(enemyDamage * 0.8f);
						players[enemyTarget].currentHealth -= enemyDamage;
					}

					if (t.characterType == Type.Ranged)
					{
						enemyDamage = Mathf.RoundToInt(enemyDamage * 1.2f);
						players[enemyTarget].currentHealth -= enemyDamage;
					}
					if (t.characterType == Type.Magic)
					{
						players[enemyTarget].currentHealth -= enemyDamage;
					}
				}

				if (players[enemyTarget].characterType == Type.Melee)
				{
					if (t.characterType == Type.Ranged)
					{
						enemyDamage = Mathf.RoundToInt(enemyDamage * 0.8f);
						players[enemyTarget].currentHealth -= enemyDamage;
					}

					if (t.characterType == Type.Magic)
					{
						enemyDamage = Mathf.RoundToInt(enemyDamage * 1.2f);
						players[enemyTarget].currentHealth -= enemyDamage;
					}
					if (t.characterType == Type.Melee)
					{
						players[enemyTarget].currentHealth -= enemyDamage;
					}
				}

				if (players[enemyTarget].characterType == Type.Ranged)
				{
					if (t.characterType == Type.Magic)
					{
						enemyDamage = Mathf.RoundToInt(enemyDamage * 0.8f);
						players[enemyTarget].currentHealth -= enemyDamage;
					}

					if (t.characterType == Type.Melee)
					{
						enemyDamage = Mathf.RoundToInt(enemyDamage * 1.2f);
						players[enemyTarget].currentHealth -= enemyDamage;
					}
					if (t.characterType == Type.Ranged)
					{
						players[enemyTarget].currentHealth -= enemyDamage;
					}
				}
			}
		}
	}
}