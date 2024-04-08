using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class CreateEndParticles : MonoBehaviour
{
    [SerializeField] private GameObject _Particles;
    [SerializeField] private Vector3 _SpawnLocation;

    
    private void OnCollisionEnter (Collision collision)
    {
        if (collision != null && collision.gameObject.tag == "Ball" && -_SpawnLocation != null)
        {
            
            Instantiate(_Particles, _SpawnLocation, Quaternion.identity);

            Destroy(collision.gameObject);
        }
    }

}
