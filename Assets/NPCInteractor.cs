using UnityEngine;
using UnityEngine.XR;
using UnityEngine.XR.Interaction.Toolkit;


public class NPCInteractor : MonoBehaviour
{
    public AudioClip goodmorningTTS;  // Assign the audio clip in the Inspector

    void Update()
    {
        if (OVRInput.Get(OVRInput.Button.PrimaryIndexTrigger)) // Check for right controller trigger press
        {
            RaycastHit hit;
            if (Physics.Raycast(transform.position, transform.forward, out hit, 100f))
            {
                if (hit.collider.gameObject.name == "Speaker")
                {
                    AudioSource audioSource = hit.collider.gameObject.GetComponent<AudioSource>();
                    if (audioSource != null)
                    {
                        audioSource.PlayOneShot(goodmorningTTS);
                    }
                }
            }
        }
    }
}
