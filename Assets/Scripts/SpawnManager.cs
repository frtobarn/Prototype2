using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    //Animals array to be respawned
    public GameObject[] animalPrefabs;

    //Respawn area(line)
    private float spawnRangeX = 20;

    private float spawnPosZ = 30;

    //Side spawn area
    private float sideSpawnMinZ = -9;

    private float sideSpawnMaxZ = 28;

    private float sideSpawnX = 25;

    //Respawn time range
    private float startDelay = 4;

    //Respawn time
    private float spawnInterval = 3.8f;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomAnimal",
        Random.Range(2.5f, 6.5f),
        Random.Range(2.5f, 6.5f));
        InvokeRepeating("SpawnLeftAnimal",
        Random.Range(2.5f, 6.5f),
        Random.Range(2.5f, 6.5f));
        InvokeRepeating("SpawnRightAnimal",
        Random.Range(2.5f, 6.5f),
        Random.Range(2.5f, 6.5f));
    }

    // Update is called once per frame
    void Update()
    {
        //Reemplazado por el InvokeRepeating("SpawnRandomAnimal", startDelay, spawnInterval);
        // if(Input.GetKeyDown(KeyCode.S)){
        //     SpawnRandomAnimal();
        //     }
    }

    void SpawnRandomAnimal()
    {
        Vector3 spawnPos =
            new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnPosZ);
        int animalIndex = Random.Range(0, animalPrefabs.Length);
        Instantiate(animalPrefabs[animalIndex],
        spawnPos,
        animalPrefabs[animalIndex].transform.rotation);
    }

    void SpawnLeftAnimal()
    {
        int animalIndex = Random.Range(0, animalPrefabs.Length);
        Vector3 spawnPos =
            new Vector3(-sideSpawnX,
                0,
                Random.Range(sideSpawnMinZ, sideSpawnMaxZ));
        Instantiate(animalPrefabs[animalIndex],
        spawnPos,
        Quaternion.Euler(new Vector3(0, 90, 0)));
    }

    void SpawnRightAnimal()
    {
        int animalIndex = Random.Range(0, animalPrefabs.Length);
        Vector3 spawnPos =
            new Vector3(sideSpawnX,
                0,
                Random.Range(sideSpawnMinZ, sideSpawnMaxZ));
        Instantiate(animalPrefabs[animalIndex],
        spawnPos,
        Quaternion.Euler(new Vector3(0, -90, 0)));
    }
}
