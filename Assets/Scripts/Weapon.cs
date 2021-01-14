using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Weapon : MonoBehaviour
{
    [Range(0, 3)] public float fireRate = 0.5f;
    [Range(1, 100)] public float angle = 10.0f;
    public int ammoMax = 100;
    public GameObject bullet;

    protected float fireTimer = 0;
    protected int ammo = 100;

    public abstract bool Fire(Vector3 position, Vector3 direction);

    void Update()
    {
        fireTimer += Time.deltaTime;
    }
}
