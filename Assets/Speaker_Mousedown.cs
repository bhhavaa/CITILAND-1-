// using System.Collections;
// using System.Collections.Generic;
// using UnityEngine;
// using UnityEngine.XR;
// using UnityEngine.XR.Interaction.Toolkit;
// using UnityEngine.EventSystems;
// using UnityEngine.Audio;

// public class PlayRickRollOnTriggerEnter : MonoBehaviour
// {
//     public AudioClip RickRoll;
 

//     AudioSource audioSource;

//     bool isAudioPlaying = false;

//     void Start()
//     {
//         audioSource = GetComponent<AudioSource>();    
//     }

//     void OnMouseDown()
//     {
//         if (isAudioPlaying)
//         {
//             audioSource.Stop();
//             isAudioPlaying = false;
//         }
//         else
//         {
//             audioSource.PlayOneShot(RickRoll); 
//             isAudioPlaying = true;
//         }
  
//     }
    
//     void OnSelectEntered(XRBaseInteractor interactor)
//     {
//         if (isAudioPlaying)
//         {
//             audioSource.Stop();
//             isAudioPlaying = false;
//         }
//         else
//         {
//             audioSource.PlayOneShot(RickRoll); 
//             isAudioPlaying = true;
//         }
        
//     }
// }
