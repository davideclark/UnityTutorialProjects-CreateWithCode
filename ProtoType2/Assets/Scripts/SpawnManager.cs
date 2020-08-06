using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class SpawnManager : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject[] animalPrefabs;

    private float spawnRange = 20;
    private float spawnPosZ = 20;

    public float sideSpawnX;

    public float sideSpawnMinZ;
    public float sideSpawnMaxZ;


    private float startDelay = 2;
    private float spawnInterval = 1.5f;
    private float aggressiveAnimalSpawnInterval = 4f;
    void Start()
    {
        InvokeRepeating("SpawnRandomAnimal", startDelay, spawnInterval);
        InvokeRepeating("SpawnRandomAnimalLeft", startDelay, aggressiveAnimalSpawnInterval);
        InvokeRepeating("SpawnRandomAnimalRight", startDelay, aggressiveAnimalSpawnInterval);
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void SpawnRandomAnimal()
    {
        int animalIndex = Random.Range(0, animalPrefabs.Length);
        Vector3 spawnPosition = new Vector3(Random.Range(-spawnRange, spawnRange), 0, spawnPosZ);
        Instantiate(animalPrefabs[animalIndex], spawnPosition, animalPrefabs[animalIndex]
            .transform.rotation);
    }

    private void SpawnRandomAnimalLeft()
    {
        int animalIndex = Random.Range(0, animalPrefabs.Length);
        Vector3 spawnPosition = new Vector3(-sideSpawnX, 0, Random.Range(-sideSpawnMinZ, sideSpawnMaxZ));
        Vector3 rotation = new Vector3(0, 90, 0);
        Instantiate(animalPrefabs[animalIndex], spawnPosition, Quaternion.Euler(rotation));
    }

    private void SpawnRandomAnimalRight()
    {
        int animalIndex = Random.Range(0, animalPrefabs.Length);
        Vector3 spawnPosition = new Vector3(-sideSpawnX, 0, Random.Range(-sideSpawnMinZ, -sideSpawnMaxZ));
        Vector3 rotation = new Vector3(0, -90, 0);
        Instantiate(animalPrefabs[animalIndex], spawnPosition, Quaternion.Euler(rotation));
    }
}
