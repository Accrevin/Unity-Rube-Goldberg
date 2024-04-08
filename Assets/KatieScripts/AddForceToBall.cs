using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[RequireComponent(typeof(Rigidbody))]

public class AddForceToBall : MonoBehaviour
{
    [SerializeField] private int _force;

    [Tooltip ("Tag of object that triggers adding force.")]
    [SerializeField] private string _tag;

    Rigidbody rb;

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
        //Only add force if collided with correct object
        if (rb != null && collision.gameObject.tag == _tag)
        {
            Debug.Log($"Collided with tag: {collision.gameObject.tag}");
            rb.AddForce(_force,0f, 0f, ForceMode.Impulse);
        }
    }


}
