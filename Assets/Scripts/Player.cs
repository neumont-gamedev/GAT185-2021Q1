using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed = 2.0f;
    public Weapon[] weapons;
<<<<<<< HEAD
 
    void Update()
    {
        //Vector3 velocity = Vector3.zero;
=======

    int weaponIndex = 0;
 
    void Update()
    {
        // movement
        Vector3 velocity = Vector3.zero;
>>>>>>> 524de3bf71b08893570fef47ff86d4982b7edc79

        //velocity.x = Input.GetAxis("Horizontal");
        //velocity.z = Input.GetAxis("Vertical");

        //if (Input.GetButtonDown("Jump")) velocity.y = 40;

<<<<<<< HEAD
        //transform.position += velocity * speed * Time.deltaTime;

        if (Input.GetButton("Fire1"))
		{
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            weapons[0].Fire(ray.origin, ray.direction);
        }
=======
        transform.position += velocity * speed * Time.deltaTime;

        // weapon
        if (Input.GetButton("Fire1"))
		{
            // get weapon direction
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            weapons[0].Fire(ray.origin, ray.direction);
		}
>>>>>>> 524de3bf71b08893570fef47ff86d4982b7edc79
    }
}
