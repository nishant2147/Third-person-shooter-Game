using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnEneny : MonoBehaviour
{
    public GameObject enemyPrefab;
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < 2; i++)
        {
            SpawnEnemy();
        }
    }

    void SpawnEnemy()
    {
        Vector3 randomPosition = new Vector3(UnityEngine.Random.Range(-19f, 19f), 1f, UnityEngine.Random.Range(-19f, 19f));
        Instantiate(enemyPrefab, randomPosition, Quaternion.identity);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
