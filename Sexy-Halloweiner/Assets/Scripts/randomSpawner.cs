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
    }
}
