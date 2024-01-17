using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.EventSystems;
using UnityEngine.Audio;




public class PlaySoundOnTriggerEnter : MonoBehaviour
{
    public AudioClip goodmorningTTS;

    AudioSource audioSource;

    // bool isAudioPlaying = false;

    // public Collider collider;


    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    void OnMouseDown()
    {
        GetComponent<AudioSource>().PlayOneShot(goodmorningTTS); 
        
    }

    void OnSelectEntered(XRBaseInteractor interactor)
    {
        GetComponent<AudioSource>().PlayOneShot(goodmorningTTS);
    }

    // public void OnPointerClick(PointerEventData eventData)
    // {
    //     GetComponent<AudioSource>().PlayOneShot(goodmorningTTS);
    // }
    
    // void OnMouseDown()
    // { 
    //     if (isAudioPlaying)
    //     {
    //         audioSource.Stop();
    //         isAudioPlaying = false;
    //     }
    //     else
    //     {
    //         audioSource.PlayOneShot(goodmorningTTS); 
    //         isAudioPlaying = true;
    //     }
    // }


    

    // void Update()
    // {
    //     // Double-click check now only applies when audio is playing.
    //     if (audioSource.isPlaying && Input.GetMouseButtonDown(0) && Input.GetMouseButtonDown(0))
    //     {
    //         StopAudio();
    //         isAudioPlaying = false;
    //     }
    // }

    // void StopAudio()
    // {
    //     if (audioSource != null && audioSource.isPlaying)
    //     {
    //         audioSource.Stop();
    //         isAudioPlaying = false;
    //     }
    // }

    // void Update()
    // {
    //    if (OVRInput.Get(OVRInput.Button.One))
    //     {
    //         RaycastHit hit;
    //         if (Physics.Raycast(transform.position, transform.forward, out hit, 10f) && hit.collider == collider)
    //         {
    //             GetComponent<AudioSource>().PlayOneShot(goodmorningTTS);
    //         }
    //     }
    // }


    // void OnTriggerEnter(Collider hit)
    // {
    //     if (OVRInput.GetActiveController(hit.GetComponent<Collider>()) != UnityEngine.XR.InputDevice.RightHand)
    //         return;

    //     GetComponent<AudioSource>().PlayOneShot(goodmorningTTS);
    // }

    
    // void OnTeleportClick()
    // {
    //     // Play the good morning sound
    //     GetComponent<AudioSource>().PlayOneShot(goodmorningTTS);

    //     // Additional actions you want to trigger (optional)
    // }


    // void OnCollisionEnter()
    // {
    //     // Play the audio using OnCollisionEnter as originally intended
    //     audioSource.PlayOneShot(goodmorningTTS, 0.7F);
    // }
}