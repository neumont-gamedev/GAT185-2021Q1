using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour
{
<<<<<<< HEAD
    public int points = 100;
    public Material material;

	private void Start()
	{
		GetComponent<Renderer>().material = material;
	}

	private void OnCollisionEnter(Collision collision)
	{
		if (collision.gameObject.CompareTag("Projectile"))
		{
			// add score to game
			Game.Instance.AddPoints(points);
		}
	}

=======
	public int Score = 100;

	private void OnCollisionEnter(Collision collision)
	{
		//if (collision.gameObject.CompareTag("Projectile"))
		{
			Game.Instance.AddScore(Score);
		}
	}
>>>>>>> 524de3bf71b08893570fef47ff86d4982b7edc79
}
