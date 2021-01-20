using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    [Range(0, 3)] public float fireRate = 0.5f;
    [Range(1, 100)] public float angle = 10.0f;
    public int ammoMax = 100;
    public GameObject bullet;

    protected float fireTimer = 0;
    protected int ammo = 100;

    void Update()
    {
        fireTimer += Time.deltaTime;
    }

    public bool Fire(Vector3 position, Vector3 direction)
	{
        if (fireTimer >= fireRate)
		{
            fireTimer = 0;
            GameObject gameObject = Instantiate(this.bullet, position, Quaternion.identity);
            gameObject.GetComponent<Bullet>().Fire(direction);

            return true;
		}

        return false;
    }
}
