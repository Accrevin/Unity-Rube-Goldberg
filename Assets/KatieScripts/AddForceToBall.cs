using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[RequireComponent(typeof(Rigidbody))]

public class AddForceToBall : MonoBehaviour
{
    [SerializeField] private float _force = -10.0f;

    [Tooltip ("Tag of object that triggers adding force.")]
    [SerializeField] private string _tag;

    Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        GetRigidbody();
    }

    private void GetRigidbody()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (rb != null && collision.gameObject.tag == _tag)
        {
            Debug.Log($"Collided with tag: {collision.gameObject.tag}");
            rb.AddForce(_force, 0, 0, ForceMode.Impulse);
        }
    }


}
