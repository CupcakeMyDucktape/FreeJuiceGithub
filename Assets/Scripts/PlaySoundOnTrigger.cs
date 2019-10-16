using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]
//play me a certain sound the sound component on this gameobject is carrying plx.

public class PlaySoundOnTrigger : MonoBehaviour
{

    AudioSource theSound;

    void Update() {
        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.W))
        {
            theSound = GetComponent<AudioSource>();
            theSound.Play(0);
            Debug.Log("PLaying sound");
        }
    }
}
