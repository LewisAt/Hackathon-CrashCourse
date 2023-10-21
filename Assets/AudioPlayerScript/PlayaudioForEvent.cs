using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayaudioForEvent : MonoBehaviour
{
    public AudioClip[] EventSounds;
    public float delay;
    private AudioSource mainCameraAudio;

    private void Awake()
    {
        mainCameraAudio = Camera.main.GetComponent<AudioSource>();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            Debug.Log("oppoooAÂ");
            TriggerAudioPlaying();
        }

    }

    public void TriggerAudioPlaying()
    {
  
        StartCoroutine("playAudioInSequence");
    }

    IEnumerator playAudioInSequence()
    {
        for(int i = 0; i < EventSounds.Length; i++)
        {

            mainCameraAudio.clip = EventSounds[i];
            mainCameraAudio.Play();
            Debug.Log("Playing Audio");

            yield return new WaitForSeconds(EventSounds[i].length + delay);
        }
        
    }

}
