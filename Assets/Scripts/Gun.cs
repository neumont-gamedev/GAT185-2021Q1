using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : Weapon
{
	public override bool Fire(Vector3 position, Vector3 direction)
	{
		if (fireTimer >= fireRate && ammo > 0)
		{
			fireTimer = 0;
			ammo--;

			Quaternion rotation = Quaternion.AngleAxis(10, Vector3.right);

			GameObject gameObject = Instantiate(this.bullet, position, Quaternion.identity);
			gameObject.GetComponent<Bullet>().Fire(rotation * direction);

			return true;
		}

		return false;
	}
}
