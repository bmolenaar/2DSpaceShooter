using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemy : MonoBehaviour {

    [SerializeField]
    private GameObject[] enemy;
    private int enemyIndex;
    private GameObject[] currentEnemies;
    public static int maxEnemies = 3;
    public GameObject[] spawnPoints;

    //////Store spawnPoints variable//////
    void Start ()
    {
        //GetRandomPosition();
        spawnPoints = GameObject.FindGameObjectsWithTag("Boundary");
    }

    //////Could be done better, quite intensive//////
    void Update ()
    {
        currentEnemies = GameObject.FindGameObjectsWithTag("Enemy");
        EnemySpawn();
    }


    //////Spawn enemies depending on which wave the player is on//////
    void EnemySpawn()
    {
        if (currentEnemies.Length < maxEnemies)
        {
            enemyIndex = UnityEngine.Random.Range(0, enemy.Length - 1);
            GameObject.Instantiate(enemy[enemyIndex], GetRandomPosition(), transform.rotation);
        }
       
    }

    private Vector2 GetRandomPosition()
    {
        spawnPoints = GameObject.FindGameObjectsWithTag("Boundary");
        Vector2 randPos = new Vector2(Random.Range(spawnPoints[3].transform.position.x / 2, spawnPoints[2].transform.position.x / 2),
                                      Random.Range(spawnPoints[0].transform.position.y, spawnPoints[1].transform.position.y));
        for (int i = 0; i < spawnPoints.Length; i++)
        {
            spawnPoints[i] = null;
        }
        //Debug.Log("Spawn Position X is a random position between " + spawnPoints[3].transform.position.x + spawnPoints[3].name + " and " + spawnPoints[2].transform.position.x + spawnPoints[2].name);

        return randPos;
        
    }
}
