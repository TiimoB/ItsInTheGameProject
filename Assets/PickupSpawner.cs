using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupSpawner : MonoBehaviour
{
    [SerializeField] private int width;
    [SerializeField] private int height;
    [SerializeField] private float spawnDelay;
    [SerializeField] private GameObject[] pickups;
    private float _nextSpawn;

    private void Start()
    {
        _nextSpawn = Time.time + spawnDelay;
    }

    void Update()
    {
        if (Time.time > _nextSpawn)
        {
            SpawnPickup();
            _nextSpawn = Time.time + spawnDelay;
        }
    }

    private void SpawnPickup()
    {
        System.Random rnd = new System.Random();
        int pickup = rnd.Next(pickups.Length);
        int x = rnd.Next(-width, width + 1);
        int y = rnd.Next(-height, height + 1);

        Instantiate(pickups[pickup], new Vector3(x,y,0), Quaternion.Euler(0,0,0));
    }
}
