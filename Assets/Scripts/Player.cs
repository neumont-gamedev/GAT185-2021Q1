using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed = 2.0f;
    public Weapon[] weapons;

    int weaponIndex = 0;
 
    void Update()
    {
        // movement
        Vector3 velocity = Vector3.zero;

        velocity.x = Input.GetAxis("Horizontal");
        velocity.z = Input.GetAxis("Vertical");

        if (Input.GetButtonDown("Jump")) velocity.y = 40;

        transform.position += velocity * speed * Time.deltaTime;

        // weapon
        if (Input.GetButton("Fire1"))
		{
            // get weapon direction
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            weapons[0].Fire(ray.origin, ray.direction);
		}
    }
}
