using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spear : Weapon
{
	protected override void AssignName()
	{
		weaponName = "Spear";
		atk = 100;
	}
	protected override void Add()
	{
		int result = atk_base + atk + 20;
		Debug.Log("武器傷害：" + result);
	}
}
