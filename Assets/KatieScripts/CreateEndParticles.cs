using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateEndParticles : MonoBehaviour
{
    [SerializeField]
    private GameObject _Particles;
    private void OnCollisionEnter(Collision collision)
    {
        if (collision != null && collision.gameObject.tag == "Ball")
        {
            Vector3 spawnLoaction = new Vector3(0f, 0f, 0f);
            Instantiate(_Particles, spawnLoaction, Quaternion.identity);
        }
    }

}
