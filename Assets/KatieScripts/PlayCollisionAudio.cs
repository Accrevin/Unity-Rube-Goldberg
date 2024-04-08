using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class PlayCollisionAudio : MonoBehaviour
{
    [SerializeField] private AudioSource _AudioSource;
    [SerializeField] private bool CanHit = false;

    void Start()
    {
        _AudioSource = GameObject.FindObjectOfType<AudioSource>();
        StartCoroutine(SetCanHit());
    }
    private void OnCollisionEnter (Collision collision)
    {
        if (collision != null && CanHit == true)
        _AudioSource.Play();
    }

    IEnumerator SetCanHit()
    {
        yield return new WaitForSeconds(3);
        CanHit = true;
    }
}
