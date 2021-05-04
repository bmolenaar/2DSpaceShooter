using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerupAttach : MonoBehaviour {

    public GameObject powerUp;
    private GameObject player;


	// Use this for initialization
	void Start ()
    {
        player = GameObject.FindGameObjectWithTag("Player");
	}
	

	void Update ()
    {
        
	}

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag == "Player")
        {
            Instantiate(powerUp, player.transform.position, player.transform.rotation);
            
        }

    }
}
