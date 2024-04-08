using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeleteIfTouchGround : MonoBehaviour
{
    // Start is called before the first frame update
    private void OnCollisionEnter(Collision collision)
    {
        if (collision != null && collision.gameObject.name == "Ground")
        {
            Destroy(gameObject);
        }
    }
}
