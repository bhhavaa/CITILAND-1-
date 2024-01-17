using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.XR;

public class PlayerStepAudio : MonoBehaviour
{
    public AudioSource playerAudioSource;
    public AudioClip cubeStepAudioClip;

    void OnTriggerEnter(Collider other)
    {
        // Check if the player collides with the target cube
        if (other.gameObject.name == "tile" && other.gameObject.layer == LayerMask.NameToLayer("TileLayer"))
        {
            // Play the audio using the reference or attached clip
            if (cubeStepAudioClip != null)
            {
                playerAudioSource.PlayOneShot(cubeStepAudioClip);
            }
            else
            {
                // Play audio from the cube itself (optional)
                AudioSource cubeAudioSource = other.GetComponent<AudioSource>();
                if (cubeAudioSource != null)
                {
                    cubeAudioSource.PlayOneShot(cubeAudioSource.clip);
                }
            }
        }
    }
}
