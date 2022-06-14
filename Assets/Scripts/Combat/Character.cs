using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Character : MonoBehaviour
{
	[SerializeField] public Ability[] abilities = new Ability[3];
	public int[] usesLeft = new int[3];
	public PlayerAttack moveset;
	public GameObject attackDisplay;
	public Type characterType;
	public int maxHealth;
	public int currentHealth;
	public string characterName;
	public Text healthDisplay;
	public Text nameDisplay;
	public bool hasAttacked;

	private void Start()
	{
		for(int i = 0; i < abilities.Length; i++)
		{
			usesLeft[i] = abilities[i].PP;
		}

		currentHealth = maxHealth;
	}

	public void OnMouseDown()
	{
		if(!attackDisplay.activeInHierarchy)
		{
			attackDisplay.SetActive(true);
		}

		healthDisplay.text = currentHealth.ToString();
		nameDisplay.text = characterName;
		
		for(int i = 0; i < abilities.Length; i++)
		{
			moveset.attacks[i].attackName.text = abilities[i].abilityName;
			moveset.attacks[i].description.text = abilities[i].description + "\n" + abilities[i].damage + " damage";
			moveset.attacks[i].icon.sprite = abilities[i].icon;
			moveset.attacks[i].type.text = abilities[i].type.ToString();
			moveset.attacks[i].PP.text = usesLeft[i] + "/" + abilities[i].PP;
		}
	}
}
