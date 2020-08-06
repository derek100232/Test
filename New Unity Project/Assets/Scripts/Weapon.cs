using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
	protected string weaponName;
	protected int atk;
	protected int atk_base;
	protected virtual void AssignName()
	{
		weaponName = "Knitfe";
		atk = 10;
		//Debug.Log("武器名稱： " + weaponName);
		//Debug.Log("攻擊力： " + atk);
	}

	protected virtual void Add()
	{
		int result = atk + atk_base;
		Debug.Log("武器傷害：" + result);
	}

	private void Start()
	{
		AssignName();
		Add();
	}
}
