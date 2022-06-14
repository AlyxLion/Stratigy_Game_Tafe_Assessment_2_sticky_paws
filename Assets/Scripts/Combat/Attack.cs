using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attack : MonoBehaviour
{
	public Character[] allies = new Character[3];

	public void AttackCommand()
	{
		for(int i = 0; i < allies.Length; i++)
		{
			if(!allies[i].hasAttacked)
			{
				int damage = allies[i].abilities[i].damage;
				allies[i].hasAttacked = true;
				print(allies[i].characterName);
				print(allies[i].abilities[i].abilityName + " " + damage);
				print(allies[i].abilities[i].PP);
			}
		}
	}
}
