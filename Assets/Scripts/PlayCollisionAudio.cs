using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class PlayCollisionAudio : MonoBehaviour
{

    [Header("Audio Settings")]
    [Tooltip("Make sure to set play on awake to be false")]
    private AudioSource _AudioSource;
    [Range(0.0f, 1.0f)]
    [SerializeField] private float _Volume;
    [SerializeField] private AudioClip _Clip;

    private bool CanHit = false;

    void Start()
    {
        _AudioSource = GameObject.FindObjectOfType<AudioSource>();
        StartCoroutine(SetCanHit());
    }
    private void OnCollisionEnter (Collision collision)
    {
        //do not disable the currently playing clip when triggered
        if (collision != null && CanHit == true)
        _AudioSource.PlayOneShot(_Clip, _Volume);
        else if (_Clip == null )
        {
            Debug.LogWarning($"{gameObject.name}: No audio clip found");
        }

    }

    //CanHit to prevent audio from playing on start
    IEnumerator SetCanHit()
    {
        yield return new WaitForSeconds(3);
        CanHit = true;
    }
}
