using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public List<GameObject> enemyPrefabsToSpawn;
    public GameObject spawner;

    public Vector3 spawnPoint;
    public float spawnStartDelay = 0;
    public float spawningInterval = 2f;

    private int spawnOffset = 3;

    // Start is called before the first frame update
    void Start()
    {
        spawnPoint = spawner.transform.position;
        InvokeRepeating("SpawnEnemy", spawnStartDelay, spawningInterval);
    }

    void SpawnEnemy()
    {
        Instantiate(enemyPrefabsToSpawn[GetRandomListIndex()], generateNewSpawnPoint(), Quaternion.identity);
    }

    int GetRandomListIndex()
    {
        int randomIndex = UnityEngine.Random.Range(0, enemyPrefabsToSpawn.Count);
        return randomIndex;
    }

    int GetRandomSpawnCoordinateOffset()
    {
        int randomSpawnOffset = UnityEngine.Random.Range(-spawnOffset, spawnOffset);
        return randomSpawnOffset;
    }

    Vector3 generateNewSpawnPoint()
    {
        Vector3 newSpawnPoint = spawnPoint + new Vector3(GetRandomSpawnCoordinateOffset(), 0, GetRandomSpawnCoordinateOffset());
        return newSpawnPoint;
    }
}
