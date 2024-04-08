using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour
{

    [SerializeField] private Vector3 _rotation;

    private bool canRotate = false;

    void Update()
    {
        //rotate
       if (canRotate == true)
        {
            transform.Rotate(_rotation * Time.deltaTime);
        } 
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision != null && collision.gameObject.tag == "Ball")
        {
            canRotate = true;
        }
    }
}
