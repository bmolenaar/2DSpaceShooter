using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaveMaster : MonoBehaviour {

    public static int wave = 1;
    public static int enemiesDestroyed;
    public static int enemiesToKill = 5;

	void Start ()
    {
		
	}
	
	void Update ()
    {
        if (enemiesDestroyed == enemiesToKill)
        {
            wave += 1;
            enemiesToKill += enemiesToKill;

            if (wave == 3)
            {
                SpawnEnemy.maxEnemies += 3;
            }

            if (wave == 7)
            {
                SpawnEnemy.maxEnemies += 3;
            }

            if (wave == 12)
            {
                SpawnEnemy.maxEnemies += 5;
            }
        }

        



	}

}
