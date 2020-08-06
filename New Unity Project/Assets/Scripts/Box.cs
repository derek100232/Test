using UnityEngine;

public class Box : MonoBehaviour, IDamage, IMovement
{
	void IDamage.Damage(int damage)
	{
		Destroy(gameObject);
	}


	void IMovement.Move(Vector3 direction)
	{
		Debug.Log("Can Not Move");
	}
}
