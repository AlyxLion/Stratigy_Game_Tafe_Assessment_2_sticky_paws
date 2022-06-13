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
				
			}
		}
	}
}
