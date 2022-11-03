using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class randomSpawner : MonoBehaviour
{
    public Transform[] spawnPoints;
    public GameObject[] EnemyPrefabs;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            int randEnemy = Random.Range(0, EnemyPrefabs.Length);
            int randSpawnPoint = Random.Range(0, spawnPoints.Length);

            Instantiate(EnemyPrefabs[randEnemy], spawnPoints[randSpawnPoint].position, transform.rotation);

        }
        
    }
}
