using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TriggerPig : MonoBehaviour
{
    public AudioSource DoorOpen;
    public AudioSource Piggy;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player") {
            Piggy.mute = true;
            DoorOpen.Play();
            int x = SceneManager.GetActiveScene().buildIndex;
            SceneManager.LoadScene(x + 1, LoadSceneMode.Single);
            
        }
    }
}
