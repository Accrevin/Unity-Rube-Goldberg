using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeleteIfTouchGround : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision != null && collision.gameObject.name == "Ground")
        {
            Destroy(gameObject);
        }
    }
}
