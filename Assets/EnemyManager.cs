using System;
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using Unity.Mathematics;
using UnityEngine;
using Random = System.Random;

public class EnemyManager : MonoBehaviour
{

    [SerializeField] private GameObject enemy;

    [SerializeField, Range(0.5f, 10) ] private float spawnDelay;

    private float _lastSpawn;
    // Start is called before the first frame update
    void Start()
    {
        _lastSpawn = Time.time;
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time > _lastSpawn + spawnDelay)
        {
            // spawn enemy
            spawnEnemy();
            _lastSpawn = Time.time;
        }

    }

    private void spawnEnemy()
    {
        Vector3 spawnPos;

        Random rnd = new Random();
        int dir = rnd.Next(0, 4);
        int offset = rnd.Next(-10, 10);

        switch (dir)
        {
            // up
            case 0:
                spawnPos = new Vector3(offset, -10, 0);
                break;
            // right
            case 1: 
                spawnPos = new Vector3(10, offset, 0);
                break;
            // down
            case 2: 
                spawnPos = new Vector3(offset, 10, 0);
                break;
            // left
            case 3: 
                spawnPos = new Vector3(-10, offset, 0);
                break;
            default:
                spawnPos = new Vector3();
                break;
        }

        Instantiate(enemy, spawnPos, quaternion.identity);
    }


}
