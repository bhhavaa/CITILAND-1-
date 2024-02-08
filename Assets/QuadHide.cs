using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.EventSystems;
using UnityEngine.Audio;
using UnityEngine.XR.Interaction.Toolkit;

public class QuadClickToHide : MonoBehaviour
{
    void OnMouseDown()
    {
        gameObject.SetActive(false);
    }

    public void OnSelectEntered(XRBaseInteractor interactor)
    {
        gameObject.SetActive(false);
    }

}
