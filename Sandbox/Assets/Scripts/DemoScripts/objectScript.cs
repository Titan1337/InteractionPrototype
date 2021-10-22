using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class objectScript : MonoBehaviour
{
    Renderer objRenderer;
    float timer = 0f;
    [SerializeField]
    private float colorChangeTime = 1.5f;
    float yPos;
    [SerializeField]
    [Range(0, 5)]
    float yRange;

    public float floatspeed;
    public bool isCorrect;
    public Color[] randomColor;
    Color newColor;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        objRenderer = GetComponent<Renderer>();
        timer += Time.deltaTime;

        if (timer >= colorChangeTime)
        {
            int randomNum = Random.Range(0, randomColor.Length);
            Debug.Log("timer" + timer);
            newColor = randomColor[randomNum];
           // Color newColor = Random.ColorHSV();
            objRenderer.material.color = newColor;
            timer = 0;
        }
        yPos = Mathf.PingPong(Time.time * floatspeed, 1) * yRange;
        transform.position = new Vector3(transform.position.x, yPos, transform.position.z);
    }
    private void OnMouseDown()
    {
        if (isCorrect)
        {
            Destroy(this.gameObject);
            Debug.Log("You Clicked Me");
        }
    }
}
