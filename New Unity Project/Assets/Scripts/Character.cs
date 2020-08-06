using UnityEngine;

public class Character : MonoBehaviour,IDamage,IMovement
{
	public int health = 10;
	void IDamage.Damage(int damage)
	{
		health -= damage;
		if (health <= 0)
		{
			Destroy(gameObject);
		}
	}

	void IMovement.Move(Vector3 direction)
	{
		if (gameObject.transform.position.x < 5)
		{
			gameObject.transform.Translate(direction * Time.deltaTime);
		}
		
	}
}
