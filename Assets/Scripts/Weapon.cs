using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Weapon : MonoBehaviour
{
<<<<<<< HEAD
    public float fireRate = 0.1f;
  
    
    int ammo = 100;
    float fireTimer = 0;

=======
    [Range(0, 3)] public float fireRate = 0.5f;
    [Range(1, 100)] public float angle = 10.0f;
    public int ammoMax = 100;
>>>>>>> 524de3bf71b08893570fef47ff86d4982b7edc79
    public GameObject bullet;

    protected float fireTimer = 0;
    protected int ammo = 100;

    public abstract bool Fire(Vector3 position, Vector3 direction);

    void Update()
    {
        fireTimer += Time.deltaTime;
<<<<<<< HEAD
        //if (Input.GetMouseButtonDown(0))
        //{
        //    Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        //    GameObject gameObject = Instantiate(this.bullet, transform.position, Quaternion.identity);
        //    gameObject.GetComponent<Bullet>().Fire(ray.direction);
        //}
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
=======
>>>>>>> 524de3bf71b08893570fef47ff86d4982b7edc79
    }
}
