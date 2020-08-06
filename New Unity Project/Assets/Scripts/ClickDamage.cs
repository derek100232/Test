using UnityEngine;

public class ClickDamage : MonoBehaviour
{
    void Update()
    {
		if (Input.GetMouseButtonDown(0))
		{
			Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
			RaycastHit hitInfo;
			if (Physics.Raycast(ray, out hitInfo))
			{
				IMovement moveable = hitInfo.collider.GetComponent<IMovement>();
				if (moveable != null)
				{
					Vector3 pos = new Vector3(5, 0, 0);
					moveable.Move(pos);
				}
				//IDamage damageable = hitInfo.collider.GetComponent<IDamage>();
				//if (damageable != null)
				//{
				//	damageable.Damage(1);
				//}
			}
		}

		if (Input.GetKeyDown(KeyCode.Space))
		{

		}
    }
}
