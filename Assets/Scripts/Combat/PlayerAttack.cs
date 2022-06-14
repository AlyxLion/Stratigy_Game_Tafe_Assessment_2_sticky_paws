using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerAttack : MonoBehaviour
{
	[System.Serializable]
	public struct Attack
	{
		public Text attackName;
		public Text description;
		public Image icon;
		public Text type;
		public Text PP;
	}

	public Attack[] attacks = new Attack[3];

	public Character currentCharacter;
	public Enemy currentEnemy;

	public void ButtonOne()
    {
        if (!currentCharacter.hasAttacked)
        {
			int damage = currentCharacter.abilities[0].damage;
			currentCharacter.usesLeft[0] -= 1;
			if (currentCharacter.abilities[0].type == Type.Magic)
			{
				if (currentEnemy.characterType == Type.Melee)
				{
					damage = Mathf.RoundToInt(damage * 1.2f);
					currentEnemy.currentHealth -= damage;
				}
				if (currentEnemy.characterType == Type.Ranged)
				{
					damage = Mathf.RoundToInt(damage * 0.8f);
					currentEnemy.currentHealth -= damage;
				}
				if (currentEnemy.characterType == Type.Magic)
				{
					currentEnemy.currentHealth -= damage;
				}
			}
			if (currentCharacter.abilities[0].type == Type.Melee)
			{
				if (currentEnemy.characterType == Type.Ranged)
				{
					damage = Mathf.RoundToInt(damage * 1.2f);
					currentEnemy.currentHealth -= damage;
				}

				if (currentEnemy.characterType == Type.Magic)
				{
					damage = Mathf.RoundToInt(damage * 0.8f);
					currentEnemy.currentHealth -= damage;
				}
				if (currentEnemy.characterType == Type.Melee)
				{
					currentEnemy.currentHealth -= damage;
				}
			}
			if (currentCharacter.abilities[0].type == Type.Ranged)
			{
				if (currentEnemy.characterType == Type.Magic)
				{
					damage = Mathf.RoundToInt(damage * 1.2f);
					currentEnemy.currentHealth -= damage;
				}

				if (currentEnemy.characterType == Type.Melee)
				{
					damage = Mathf.RoundToInt(damage * 0.8f);
					currentEnemy.currentHealth -= damage;
				}
				if (currentEnemy.characterType == Type.Ranged)
				{
					currentEnemy.currentHealth -= damage;
				}
			}
			currentCharacter.hasAttacked = true;

			currentEnemy.hpDisplay.text = currentEnemy.currentHealth.ToString();
			currentCharacter.moveset.attacks[0].PP.text = currentCharacter.usesLeft[0] + "/" + currentCharacter.abilities[0].PP;
		}
    }
	public void ButtonTwo()
	{
		if (!currentCharacter.hasAttacked)
		{
			int damage = currentCharacter.abilities[1].damage;
			currentCharacter.usesLeft[1] -= 1;
			if (currentCharacter.abilities[1].type == Type.Magic)
			{
				if (currentEnemy.characterType == Type.Melee)
				{
					damage = Mathf.RoundToInt(damage * 1.2f);
					currentEnemy.currentHealth -= damage;
				}
				if (currentEnemy.characterType == Type.Ranged)
				{
					damage = Mathf.RoundToInt(damage * 0.8f);
					currentEnemy.currentHealth -= damage;
				}
				if (currentEnemy.characterType == Type.Magic)
				{
					currentEnemy.currentHealth -= damage;
				}
			}
			if (currentCharacter.abilities[1].type == Type.Melee)
			{
				if (currentEnemy.characterType == Type.Ranged)
				{
					damage = Mathf.RoundToInt(damage * 1.2f);
					currentEnemy.currentHealth -= damage;
				}

				if (currentEnemy.characterType == Type.Magic)
				{
					damage = Mathf.RoundToInt(damage * 0.8f);
					currentEnemy.currentHealth -= damage;
				}
				if (currentEnemy.characterType == Type.Melee)
				{
					currentEnemy.currentHealth -= damage;
				}
			}
			if (currentCharacter.abilities[1].type == Type.Ranged)
			{
				if (currentEnemy.characterType == Type.Magic)
				{
					damage = Mathf.RoundToInt(damage * 1.2f);
					currentEnemy.currentHealth -= damage;
				}

				if (currentEnemy.characterType == Type.Melee)
				{
					damage = Mathf.RoundToInt(damage * 0.8f);
					currentEnemy.currentHealth -= damage;
				}
				if (currentEnemy.characterType == Type.Ranged)
				{
					currentEnemy.currentHealth -= damage;
				}
			}
			currentCharacter.hasAttacked = true;

			currentEnemy.hpDisplay.text = currentEnemy.currentHealth.ToString();
			currentCharacter.moveset.attacks[1].PP.text = currentCharacter.usesLeft[1] + "/" + currentCharacter.abilities[1].PP;
		}
	}
	public void ButtonThree()
	{
		if (!currentCharacter.hasAttacked)
		{
			int damage = currentCharacter.abilities[2].damage;
			currentCharacter.usesLeft[2] -= 1;
			if (currentCharacter.abilities[2].type == Type.Magic)
			{
				if (currentEnemy.characterType == Type.Melee)
				{
					damage = Mathf.RoundToInt(damage * 1.2f);
					currentEnemy.currentHealth -= damage;
				}
				if (currentEnemy.characterType == Type.Ranged)
				{
					damage = Mathf.RoundToInt(damage * 0.8f);
					currentEnemy.currentHealth -= damage;
				}
				if (currentEnemy.characterType == Type.Magic)
				{
					currentEnemy.currentHealth -= damage;
				}
			}
			if (currentCharacter.abilities[2].type == Type.Melee)
			{
				if (currentEnemy.characterType == Type.Ranged)
				{
					damage = Mathf.RoundToInt(damage * 1.2f);
					currentEnemy.currentHealth -= damage;
				}

				if (currentEnemy.characterType == Type.Magic)
				{
					damage = Mathf.RoundToInt(damage * 0.8f);
					currentEnemy.currentHealth -= damage;
				}
				if (currentEnemy.characterType == Type.Melee)
				{
					currentEnemy.currentHealth -= damage;
				}
			}
			if (currentCharacter.abilities[2].type == Type.Ranged)
			{
				if (currentEnemy.characterType == Type.Magic)
				{
					damage = Mathf.RoundToInt(damage * 1.2f);
					currentEnemy.currentHealth -= damage;
				}

				if (currentEnemy.characterType == Type.Melee)
				{
					damage = Mathf.RoundToInt(damage * 0.8f);
					currentEnemy.currentHealth -= damage;
				}
				if (currentEnemy.characterType == Type.Ranged)
				{
					currentEnemy.currentHealth -= damage;
				}
			}
			currentCharacter.hasAttacked = true;

			currentEnemy.hpDisplay.text = currentEnemy.currentHealth.ToString();
			currentCharacter.moveset.attacks[2].PP.text = currentCharacter.usesLeft[2] + "/" + currentCharacter.abilities[2].PP;
		}
	}
}
