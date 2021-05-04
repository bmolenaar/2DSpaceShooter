using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundGeneration : MonoBehaviour
{

    public GameObject bg;
    private GameObject player;
    private Vector3 playerPos;
    List<GameObject> boundaries = new List<GameObject>();
    List<GameObject> backgrounds = new List<GameObject>();
    private GameObject spawner;
    
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        boundaries.AddRange(GameObject.FindGameObjectsWithTag("Boundary"));
        destroyOldBackgrounds();
    }

    
    void Update()
    {

    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        
        {
            enableBounds();
            if (collision.gameObject.tag == "Player")
            {
                playerPos = player.transform.position;
                GameObject.Instantiate(bg, playerPos, new Quaternion(0, 0, 0, 0));
                spawner = GameObject.Find("Spawner");
                Destroy(spawner);
                foreach (GameObject bound in boundaries)
                {
                    Destroy(bound);
                }
                
            }
            
            
        }
        

    }

    private void enableBounds()
    {

        foreach (GameObject bounds in boundaries)
        {
            
            if (bounds != null)
            {
                if (bounds.activeInHierarchy == false)
                {
                    bounds.SetActive(true);
                }

            }        
        }
    }

    private void destroyOldBackgrounds()
    {
        backgrounds.AddRange(GameObject.FindGameObjectsWithTag("Background"));
        if (backgrounds.Count >= 10)
        {
            for (int i = 0; i < backgrounds.Count - 2; i++)
            {
                GameObject.Destroy(backgrounds[i]);
                backgrounds.RemoveRange(0, backgrounds.Count - 2);
            }
            
            
        }
    }

}
