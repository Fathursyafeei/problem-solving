﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawerRectangle : MonoBehaviour
{
    public GameObject enemy;
    public float xMin, xMax, yMin, yMax;

    // Start is called before the first frame update
    void Start()
    {
        Spawn();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void Spawn()
    {
        int randJlhRectangle = Random.Range(6, 12);
        for(int i = 0; i < 10 ; i++)
        { 
            float spawnX = Random.Range(xMin, xMax);
            float spawnY = Random.Range(yMin, yMax);

            Vector2 spawnPosition = new Vector2(spawnX, spawnY);
            Instantiate(enemy, spawnPosition, Quaternion.identity);

        }
    }

}