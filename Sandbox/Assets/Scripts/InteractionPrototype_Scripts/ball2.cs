using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class ball2 : MonoBehaviour
{
    private XRGrabInteractable grabInteractable;

    public AudioSource triggerAudio;

    // Start is called before the first frame update
    void Awake()
    {
        grabInteractable = GetComponent<XRGrabInteractable>();
        grabInteractable.activated.AddListener(Squeak);
    }

    private void Squeak(ActivateEventArgs arg0)
    {
        triggerAudio.Play();
    }
}
