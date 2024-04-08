using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class CreateEndParticles : MonoBehaviour
{
    [SerializeField]
    private GameObject _Particles;
    private void OnCollisionEnter (Collision collision)
    {
        if (collision != null && collision.gameObject.tag == "Ball")
        {
            Vector3 spawnLoaction = new Vector3(127.3f, 0f, 69.48f);
            Instantiate(_Particles, spawnLoaction, Quaternion.identity);

            Destroy(collision.gameObject);
        }
    }

}
