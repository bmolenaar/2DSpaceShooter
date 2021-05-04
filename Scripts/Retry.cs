using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityStandardAssets.CrossPlatformInput;

public class Retry : MonoBehaviour {

    private Scene currentScene;

	void Start ()
    {
        currentScene = SceneManager.GetActiveScene();
	}
	
	void Update ()
    {
		
	}

    public void ReloadGame()
    {
        if (currentScene != null)
        {
            SceneManager.LoadScene(currentScene.name);
        }
        WaveMaster.enemiesDestroyed = 0;
        WaveMaster.enemiesToKill = 5;
        WaveMaster.wave = 1;
        ScoreMaster.masterScore = 0f;
        SpawnEnemy.maxEnemies = 3;


    }

}
