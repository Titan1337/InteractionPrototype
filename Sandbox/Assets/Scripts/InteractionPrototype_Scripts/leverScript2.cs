using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class leverScript2 : MonoBehaviour
{
    private HingeJoint hinge;

    
    public AudioSource triggerAudio;

    // Start is called before the first frame update
    void Start()
    {
        hinge = GetComponent<HingeJoint>();
    }

    // Update is called once per frame
    void Update()
    {
        if (hinge.angle == hinge.limits.min)
        {
            triggerAudio.Play();
        }
    }
}
