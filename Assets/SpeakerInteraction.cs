using UnityEngine;
using UnityEngine.Video;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.EventSystems;
using UnityEngine.Audio;


public class SpeakerInteraction : MonoBehaviour
{
    public GameObject QuadObject; // Reference to your Quad GameObject
    private VideoPlayer videoPlayer; // Reference to the VideoPlayer component

    void Start()
    {
        // Hide the Quad initially
        QuadObject.SetActive(false);

        // Get the VideoPlayer component from the Quad GameObject
        videoPlayer = QuadObject.GetComponent<VideoPlayer>();

        // Subscribe to the loopPointReached event
        if (videoPlayer != null)
        {
            videoPlayer.loopPointReached += VideoFinished;
        }
    }

    public void OnSelectEntered(XRBaseInteractor interactor)
    {
        // Speaker GameObject clicked, show the Quad
        QuadObject.SetActive(true);

        // Optionally, start playing the video on the Quad's VideoPlayer component
        if (videoPlayer != null)
        {
            videoPlayer.Play();
        }
    }

    void OnMouseDown()
    {
        // Speaker GameObject clicked, show the Quad
        QuadObject.SetActive(true);

        // Optionally, start playing the video on the Quad's VideoPlayer component
        if (videoPlayer != null)
        {
            videoPlayer.Play();
        }
    }

    // Method called when the video finishes playing    
    void VideoFinished(VideoPlayer vp)
    {
        // Hide the Quad when the video finishes
        QuadObject.SetActive(false);
    }

    // Unsubscribe from events when the script is destroyed
    void OnDestroy()
    {
        if (videoPlayer != null)
        {
            videoPlayer.loopPointReached -= VideoFinished;
        }
    }
}