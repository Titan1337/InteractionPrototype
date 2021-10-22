using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bubbleFloat : MonoBehaviour
{
    private Rigidbody rb;

    [SerializeField]
    float speed;
    [SerializeField]
    float lifespan;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.AddForce(Vector3.forward * (speed / 2), ForceMode.VelocityChange);
        rb.AddForce(Vector3.up * speed, ForceMode.VelocityChange);
    }

    // Update is called once per frame
    void Update()
    {
        if (lifespan >= 0)
        {
            lifespan -= Time.deltaTime;
        }
        else
        {
            Destroy(gameObject);
        }
    }
}
