using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class audioTrigger : MonoBehaviour
{
    public AudioSource triggerAudio;

    private void OnTriggerEnter(Collider other)
    {
        triggerAudio.Play();
    }
}
