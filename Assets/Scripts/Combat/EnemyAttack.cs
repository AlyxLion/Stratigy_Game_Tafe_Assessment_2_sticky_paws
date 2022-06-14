using System.Collections;
using System.Collections.Generic;

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

	public void Target() // Determines who to target
	{
		for(int i = 0; i < players.Length; i++) 
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
		print(enemyTarget);
		//return enemyTarget;
		AttackPhase();
	}

	public void AttackPhase() // Checks for advantage/disadvantage
	{
		foreach(Enemy t in enemies)
		{
			if(players[enemyTarget].characterType == Type.Magic)
			{
				if(t.characterType == Type.Melee)
				{
					enemyDamage = Mathf.RoundToInt(enemyDamage * 0.8f);
					players[enemyTarget].currentHealth -= enemyDamage;
				}

				if(t.characterType == Type.Ranged)
				{
					enemyDamage = Mathf.RoundToInt(enemyDamage * 1.2f);
					players[enemyTarget].currentHealth -= enemyDamage;
				}
				if (t.characterType == Type.Magic)
				{
					players[enemyTarget].currentHealth -= enemyDamage;
				}
			}

			if(players[enemyTarget].characterType == Type.Melee)
			{
				if(t.characterType == Type.Ranged)
				{
					enemyDamage = Mathf.RoundToInt(enemyDamage * 0.8f);
					players[enemyTarget].currentHealth -= enemyDamage;
				}

				if(t.characterType == Type.Magic)
				{
					enemyDamage = Mathf.RoundToInt(enemyDamage * 1.2f);
					players[enemyTarget].currentHealth -= enemyDamage;
				}
				if (t.characterType == Type.Melee)
				{
					players[enemyTarget].currentHealth -= enemyDamage;
				}
			}

			if(players[enemyTarget].characterType == Type.Ranged)
			{
				if(t.characterType == Type.Magic)
				{
					enemyDamage = Mathf.RoundToInt(enemyDamage * 0.8f);
					players[enemyTarget].currentHealth -= enemyDamage;
				}

				if(t.characterType == Type.Melee)
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