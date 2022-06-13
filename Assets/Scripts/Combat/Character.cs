using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
	[SerializeField] public Ability[] abilities = new Ability[3];
	public int[] usesLeft = new int[3];
	public PlayerAttack moveset;
	public GameObject attackDisplay;

	private void Start()
	{
		for(int i = 0; i < abilities.Length; i++)
		{
			usesLeft[i] = abilities[i].PP;
		}
	}

	public void OnMouseDown()
	{
		if(!attackDisplay.activeInHierarchy)
		{
			attackDisplay.SetActive(true);
		}
		for(int i = 0; i < abilities.Length; i++)
		{
			moveset.attacks[i].attackName.text = abilities[i].abilityName;
			moveset.attacks[i].description.text = abilities[i].description + " - " + abilities[i].damage + " damage";
			moveset.attacks[i].icon.sprite = abilities[i].icon;
			moveset.attacks[i].type.text = abilities[i].type.ToString();
			moveset.attacks[i].PP.text = usesLeft[i] + "/" + abilities[i].PP;
		}
	}
}
