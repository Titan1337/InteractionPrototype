using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class playback : MonoBehaviour
{
    public AudioSource audioSource;
    
    // Update is called once per frame
    //void Update()
    //{
    //    if (Input.GetKeyDown(KeyCode.Space))
    //    {
    //        audioSource.Play();
    //    }
    //}

    //private void OnMouseDown()
    //{
    //    audioSource.Play();
    //}

    void OnFire()
    {
       audioSource.Play();
    }
    
    void OnPlayAudio()
    {
        audioSource.Play();
    }
}
