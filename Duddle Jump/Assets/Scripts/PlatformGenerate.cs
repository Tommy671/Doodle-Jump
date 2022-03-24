using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformGenerate : MonoBehaviour
{
    public GameObject platformPrefab;

    void Start()
    {
        Vector3 SpawnerPosition = new Vector3();

        for (int i = 0; i < 15; i++)
        {
            SpawnerPosition.x = Random.Range(-2f, 2f);
            SpawnerPosition.y += Random.Range(1f, 2f);

            Instantiate(platformPrefab, SpawnerPosition, Quaternion.identity);
        }

    }

    
    void Update()
    {
        
    }
}
