using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnManager : MonoBehaviour
{
    [SerializeReference]
    private GameObject[] spawnPoints;
    [SerializeField]
    GameObject objectPrefab;
    // Start is called before the first frame update
    void Start()
    {
        //spawnPoints = GameObject.FindGameObjectsWithTag("SpawnPoint");
        foreach (GameObject spawn in spawnPoints)
        {
            GameObject spawnObject = Instantiate(objectPrefab, spawn.transform, false);
            objectScript objectScript = spawnObject.GetComponent<objectScript>();
            //spawnObject.GetComponent<objectScript>().floatspeed = Random.Range(1, 3);
            objectScript.floatspeed = Random.Range(1, 3);
            int randomNum = Random.Range(1, 4);
            if (randomNum <=2)
            {
                objectScript.isCorrect = true;
            }
            else
            {
                objectScript.isCorrect = false;
            }

        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
