using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

    //This is an Array that lists the different things needed for an audiosource you wish to effect.
    [System.Serializable]
    public class SoundListClass {

        //[Tooltip("Size of the List.")]
        //public int Size;
        [Tooltip("This is the AudioSource you wish to play when the player collides with the object.")]
        public AudioSource Audio;
        [Tooltip("Check if you want to Mute the Audio on trigger enter.")]
        public bool MuteIt;
        [Tooltip("Check if you want this to switch the complete scene.")]
        public bool SceneSwitch;
}
    

    //This is the trigger script itself. On trigger enter it can activate different things.
public class TriggerScript : MonoBehaviour {

    public SoundListClass[];

    public SoundListClass SoundList;

    private void OnTriggerEnter(Collider other) {

        if (other.tag == "Player") {
            //if () {
            //}
            SoundList.Audio.Play();

            if (SoundList.SceneSwitch == true) {
                int x = SceneManager.GetActiveScene().buildIndex;
                SceneManager.LoadScene(x + 1, LoadSceneMode.Single);
            }
        }
    }
}
