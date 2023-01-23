using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class DrumElementManager : MonoBehaviour
{
    private AudioSource _audioSource;

    // Start is called before the first frame update
    void Start()
    {
        _audioSource = GetComponent<AudioSource>();
    }
    

    private void OnCollisionEnter(Collision collision)
    {
        float _pitch = Random.Range(0.90f, 1.10f);
        _audioSource.pitch = _pitch;

        _audioSource.volume = collision.relativeVelocity.magnitude;
        
        _audioSource.Play();
    }
}
