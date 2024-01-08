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

    public int enemyCount;
    public int waveNumber = 1;

    // Start is called before the first frame update
    void Start()
    {
        spawnPoint = spawner.transform.position;
        SpawnEnemyWave(waveNumber);
    }

    void Update()
    {
        enemyCount = FindObjectsOfType<Enemy>().Length;

        if (enemyCount == 0)
        {
            waveNumber += 1;
            SpawnEnemyWave(waveNumber);

        }
    }

    private void SpawnEnemyWave(int amount)
    {
        for (int i = 0; i < amount; i++)
        {
            SpawnEnemy();
        }
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
