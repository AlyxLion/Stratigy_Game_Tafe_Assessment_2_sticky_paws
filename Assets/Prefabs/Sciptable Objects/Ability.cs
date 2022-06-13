using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Ability", menuName = "ScriptableObjects/Ability")]
public class Ability : ScriptableObject
{
	public string abilityName;
	public string description;
	public Sprite icon;
	public int damage;
	public int PP;
	public Type type;
}

public enum Type
{
	Ranged,
	Melee,
	Magic,
	Normal // would be status moves or all-powerful moves maybe. probably won't be implemented.
}
