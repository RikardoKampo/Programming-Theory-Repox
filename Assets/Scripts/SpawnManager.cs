using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
   public GameObject[] shapePrefabs;
   private float spawnRangeX = 4.5f;
   private float spawnPosZ = 4;
   private float startDelay = 2.0f;
   private float spawnInterval = 2;

   void Start()
   {
      InvokeRepeating("SpawnShape", startDelay, spawnInterval);
   }

   void SpawnShape()
   {
      int animalIndex = Random.Range(0, shapePrefabs.Length);
      Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnPosZ), 1, spawnPosZ);
      Instantiate(shapePrefabs[animalIndex], spawnPos, shapePrefabs[animalIndex].transform.rotation);
   }
}