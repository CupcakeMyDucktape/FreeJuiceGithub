using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]
//pay me a certain sound the sound component on this gameobject is carrying plx.

public class PlaySoundOnTrigger : MonoBehaviour
{

    AudioSource theSound;

    void OnTriggerEnter(Collider other) {
        theSound = GetComponent<AudioSource>();
        theSound.Play(0);
        Debug.Log(other.name + "entered the water, playing sound");   
    }
}
