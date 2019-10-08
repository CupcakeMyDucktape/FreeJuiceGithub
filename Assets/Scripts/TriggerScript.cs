using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

    //This is an Array that lists the different things needed for an audiosource you wish to effect.
    [System.Serializable]
    public class SoundListClass {
        [Tooltip("Type what type of Element this is")]
        public string WhatsThis;
        [Tooltip("This is the AudioSource you wish to play when the player collides with the object.")]
        public AudioSource Audio;
        [Tooltip("Check if you want to Mute the Audio on trigger enter.")]
        public bool MuteIt;
        [Tooltip("Check this if you wish to play the sound delayed.")]
        public bool Delay;
        [Tooltip("Fill in if you want a different delay time. The normal time is 1 second.")]
        public float DelayTime = 1;
        [Tooltip("Check if you want this to switch the complete scene.")]
        public bool SceneSwitch;
        
}

    //This is the trigger script itself. On trigger enter it can activate different things.
public class TriggerScript : MonoBehaviour {

    //This says that the SoundListClass is a List. 
    public List<SoundListClass> SoundListList = new List<SoundListClass>();

    //On trigger enter
    private void OnTriggerEnter(Collider other) {

        //It will run through all of this for each item in the list.
        foreach (SoundListClass SoundList in SoundListList) {

            if (other.tag == "Player") {
                if (SoundList.MuteIt == true) {                 
                        SoundList.Audio.mute = true;
                }

                else if (SoundList.Audio.mute == true && SoundList.MuteIt == false) {
                    if (SoundList.Delay == true)
                    {
                        SoundList.Audio.PlayDelayed(SoundList.DelayTime);
                        SoundList.Audio.mute = false;
                    }
                    else if (SoundList.Delay != true) {
                        SoundList.Audio.mute = false;
                        SoundList.Audio.Play();
                    }
                }

                if (SoundList.SceneSwitch == true) {
                    int x = SceneManager.GetActiveScene().buildIndex;
                    SceneManager.LoadScene(x + 1, LoadSceneMode.Single);
                }
            }
        }
    }
}
