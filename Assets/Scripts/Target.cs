using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour
{
	public int Score = 100;

	private void OnCollisionEnter(Collision collision)
	{
		//if (collision.gameObject.CompareTag("Projectile"))
		{
			Game.Instance.AddScore(Score);
		}
	}
}
