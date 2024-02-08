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

    bool isAudioPlaying = false;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();    
    }

    void OnMouseDown()
    {
        if (isAudioPlaying)
        {
            audioSource.Stop();
            isAudioPlaying = false;
        }
        else
        {
            audioSource.PlayOneShot(goodmorningTTS); 
            isAudioPlaying = true;
        }
  
    }
    
    public void OnSelectEntered(XRBaseInteractor interactor)
    {
        if (isAudioPlaying)
        {
            audioSource.Stop();
            isAudioPlaying = false;
        }
        else
        {
            audioSource.PlayOneShot(goodmorningTTS); 
            isAudioPlaying = true;
        }
        
    }
}

// public class NPCClickTrigger : MonoBehaviour
// {
//     void OnMouseDown()
//     {
//         TextToSpeechManager ttsManager = GetComponent<TextToSpeechManager>();
//         if (ttsManager != null)
//         {
//             ttsManager.OnNPCClicked();
//         }
//         else
//         {
//             Debug.LogWarning("TextToSpeechManager component not found on this object.");
//         }
//     }

//     void OnSelectEntered(XRBaseInteractor interactor)
//     {
//         // Same logic as OnMouseDown, for XR interactions
//         TextToSpeechManager ttsManager = GetComponent<TextToSpeechManager>();
//         if (ttsManager != null)
//         {
//             ttsManager.OnNPCClicked();
//         }
//         else
//         {
//             Debug.LogWarning("TextToSpeechManager component not found on this object.");
//         }
//     }
// }


// using System.Collections;
// using System.Collections.Generic;
// using UnityEngine;
// using UnityEngine.XR;
// using UnityEngine.XR.Interaction.Toolkit;
// using UnityEngine.EventSystems;
// using UnityEngine.Audio;
// using System.Threading.Tasks; // For async/await

// public class PlaySoundOnTriggerEnter : MonoBehaviour
// {
//     private GoogleCloudTTS tts = new GoogleCloudTTS(); // Instance of the TTS class

//     AudioSource audioSource;
//     bool isAudioPlaying = false;

//     // ... (Other variables and methods)

//     void Start()
//     {
//         audioSource = GetComponent<AudioSource>();
//     }

//     // Triggered when object is clicked
//     void OnMouseDown()
//     {
//         ToggleAudioPlayback("Good morning!"); // Or any text you want to synthesize
//     }

//     // Triggered when object is selected with XR controller
//     void OnSelectEntered(XRBaseInteractor interactor)
//     {
//         ToggleAudioPlayback("Good morning!"); // Or any text you want to synthesize
//     }

//     async void ToggleAudioPlayback(string textToSpeak)
//     {
//         if (isAudioPlaying)
//         {
//             audioSource.Stop();
//             isAudioPlaying = false;
//         }
//         else
//         {
//             await tts.Synthesize(textToSpeak); // Asynchronously synthesize text
//             isAudioPlaying = true;
//         }
//     }
// }
