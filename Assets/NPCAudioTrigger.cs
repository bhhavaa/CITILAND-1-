using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class NPCAudioTrigger : MonoBehaviour
{
    public AudioClip audioToPlay;  // Assign the audio clip in the Inspector

    private void OnSelectEntered(SelectEnterEventArgs args)
    {
        AudioSource audioSource = GetComponent<AudioSource>();
        if (audioSource != null)
        {
            audioSource.PlayOneShot(audioToPlay);
        }
    }
}
