using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.EventSystems;
using UnityEngine.Audio;


public class ClickToDisappear : MonoBehaviour
{
    void OnMouseDown()
    {
        gameObject.SetActive(false);  // Deactivate the current GameObject (the NPC)
        // Play animations/audio for NPC disappearance (optional)
    }
    
    public void OnSelectEntered(XRBaseInteractor interactor)
    {
        gameObject.SetActive(false);  // Deactivate the current GameObject (the NPC)
    }
}