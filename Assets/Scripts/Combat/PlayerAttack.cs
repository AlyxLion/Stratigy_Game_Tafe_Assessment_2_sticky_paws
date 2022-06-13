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
}
