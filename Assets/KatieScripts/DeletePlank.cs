using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class DeletePlank : MonoBehaviour
{
    [SerializeField]
    Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision != null  && collision.gameObject.tag == "Ball") 
        {
            Destroy(gameObject);
        }
    }
}
