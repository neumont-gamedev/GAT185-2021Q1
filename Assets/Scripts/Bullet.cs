using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class Bullet : MonoBehaviour
{
    [Range(1, 100)] public float speed = 10.0f;
    [Range(-180, 180)] public float angle = 0.0f;

    public void Fire(Vector3 forward)
    {
        Rigidbody rigidbody = GetComponent<Rigidbody>();
        //rigidbody.AddForce(forward * speed, ForceMode.VelocityChange);
        Quaternion rotation = Quaternion.AngleAxis(angle, Vector3.right);
        rigidbody.AddForce(rotation * forward * speed, ForceMode.VelocityChange);
    }
}
