using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class Greenade : MonoBehaviour
{
    [Range(1, 100)] public float speed = 10.0f;
    [Range(1, 100)] public float angle = 10.0f;

    public void Fire(Vector3 direction)
    {
        Rigidbody rigidbody = GetComponent<Rigidbody>();

        Quaternion rotation = Quaternion.AngleAxis(10, Vector3.right);
        rigidbody.AddForce(rotation * direction * speed, ForceMode.VelocityChange);
    }
}
