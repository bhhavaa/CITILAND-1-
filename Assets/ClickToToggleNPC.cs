using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.EventSystems;
using UnityEngine.Audio;

public class ClickToToggleNPC : MonoBehaviour
{
    public GameObject HiddenNPC;  // Reference to the NPC GameObject in the Inspector

    public AudioClip JumpscareSound;
 

    AudioSource audioSource;

    // bool isAudioPlaying = false;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();    
    }

    void OnMouseDown()
    {
        HiddenNPC.SetActive(true);  // Make the NPC GameObject active (visible)
        
        if (!audioSource.isPlaying)
        {
            audioSource.PlayOneShot(JumpscareSound);
        }
    }

    public void OnSelectEntered(XRBaseInteractor interactor)
    {
        HiddenNPC.SetActive(true);  // Make the NPC GameObject active (visible)

        if (!audioSource.isPlaying)
        {
            audioSource.PlayOneShot(JumpscareSound);
        }
    }
}