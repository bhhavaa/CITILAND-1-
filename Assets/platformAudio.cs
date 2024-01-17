using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;

public class PlatformAudio : MonoBehaviour
{
    public AudioClip goodmorningTTS2; // Assign your desired audio clip here
    public AudioSource audioSource;

    public const int TileLayer = 0;

    void OnTriggerEnter(Collider other)
    {
        // if (other.gameObject.tag == "VR Player", "Player", "Player2") // Replace "Player" with your player's tag if different
        // {
        //     AudioSource.PlayClipAtPoint(goodmorningTTS2, transform.position); // Plays the sound at the platform's location
        // }
        // if (other.gameObject. == "VR Player" || other.gameObject.tag == "Player" || other.gameObject.tag == "Player2")
        if (other.gameObject.layer == TileLayer)
        {
            // AudioSource.PlayClipAtPoint(goodmorningTTS2, transform.position);
            GetComponent<AudioSource>().PlayOneShot(goodmorningTTS2);
        }

    }

     void OnTriggerExit(Collider other)
    {
        if (other.gameObject.layer == TileLayer)
        {
            GetComponent<AudioSource>().Stop(); // Stop the audio here
        }
    }
}
