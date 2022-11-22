using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting.Antlr3.Runtime;
using UnityEngine;

public class randomSpawner : MonoBehaviour
{
    public Transform[] spawnPoints;
    public GameObject[] EnemyPrefabs;
    public bool spawnEnemies = true;
    public int spawnCount = 0;
    private int prefabVariationIndicator = 0;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SpawnZombie());
    }

    // Update is called once per frame
    void Update()
    {
        /*if (Input.GetMouseButtonDown(0))
        {
            int randEnemy = Random.Range(0, EnemyPrefabs.Length);
            int randSpawnPoint = Random.Range(0, spawnPoints.Length);
            
            Instantiate(EnemyPrefabs[randEnemy], spawnPoints[randSpawnPoint].position, transform.rotation);

        }*/

    }
    /*
    private IEnumerator SpawnZombie()
    {
        while(spawnEnemies == true)
        {
            yield return new WaitForSeconds(5);
            int randEnemy = Random.Range(0, EnemyPrefabs.Length);
            int randSpawnPoint = Random.Range(0, spawnPoints.Length);
            Instantiate(EnemyPrefabs[randEnemy], spawnPoints[randSpawnPoint].position, transform.rotation);
            spawnCount += 1;
        }
        yield return null;
    }*/

    private IEnumerator SpawnZombie()
    {
        while (spawnEnemies == true)
        {
            yield return new WaitForSeconds(8);
            int randEnemy;
            if (prefabVariationIndicator <= 2)
            {
                randEnemy = 0;
                Debug.Log("Spawning normal zombie");
            }
            else{
                randEnemy = 1;
                prefabVariationIndicator = 0;
                Debug.Log("Spawning Blood Zombie");
            }
            int randSpawnPoint = Random.Range(0, spawnPoints.Length);
            Instantiate(EnemyPrefabs[randEnemy], spawnPoints[randSpawnPoint].position, transform.rotation);
            spawnCount += 1;
            prefabVariationIndicator += 1;
        }
        yield return null;
    }
}
