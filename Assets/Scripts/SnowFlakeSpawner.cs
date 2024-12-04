using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnowFlakeSpawner : MonoBehaviour
{
    public GameObject snowflakePrefab;

    public Transform[] spawnLocations;

    public float timeDelay = 3f;
    [SerializeField] private float timer;
    
    void Start()
    {
        timer = 0;
    }

    
    void Update()
    {
        if (timer > timeDelay)
        {
            for (int i = 0; i < spawnLocations.Length; i++)
            {
                Instantiate(snowflakePrefab, spawnLocations[i]);

                snowflakePrefab.transform.position = spawnLocations[i].transform.position;

                timer = 0;
            }
        }
        else
        {
            timer += Time.deltaTime;
        }
    }
}
