using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPowerup : MonoBehaviour {

    public GameObject[] powerUps;
    private int spawnIndex;
    public GameObject[] spawnPoints;
    public float spawnTimer;

    float maxTime = 5;
    float minTime = 2;
    int maxObjects = 1;
    public static int currentObjects = 0;

	void Start ()
    {
        //waitTime = UnityEngine.Random.Range(1, 2);
        //time = minTime;
    }
	
	// Update is called once per frame
	void FixedUpdate ()
    {

        spawnTimer -= Time.deltaTime;
        if (spawnTimer <= 0 && currentObjects < maxObjects)
        {         
            spawnObject();
        }

    }

    void spawnObject()
    {
        currentObjects += 1;
        Instantiate(powerUps[0], GetRandomPosition(), gameObject.transform.rotation);
        spawnTimer = Random.Range(minTime, maxTime);
    }


    private Vector2 GetRandomPosition()
    {
        spawnPoints = GameObject.FindGameObjectsWithTag("Boundary");
        Vector2 randPos = new Vector2(Random.Range(-spawnPoints[3].transform.position.x, spawnPoints[3].transform.position.x),
                                      Random.Range(-spawnPoints[0].transform.position.y, spawnPoints[0].transform.position.y));

        Vector2 pos = new Vector2(gameObject.transform.position.x, gameObject.transform.position.y) + randPos;
        Debug.Log(randPos);
        return randPos;
    }


}
