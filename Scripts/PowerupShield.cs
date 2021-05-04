using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerupShield : MonoBehaviour {


    private Collider2D playerCol2D;
	void Start ()
    {       
        playerCol2D = GameObject.FindGameObjectWithTag("Player").GetComponent<PolygonCollider2D>();
	}
	
	// Update is called once per frame
	void Update ()
    {
        transform.position = playerCol2D.transform.position;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider == playerCol2D)
        {
            Physics2D.IgnoreCollision(playerCol2D, gameObject.GetComponent<CircleCollider2D>());
        }

        if (collision.collider.tag == "Enemy" || collision.collider.tag == "EnemyBullet")
        {
            Destroy(collision.gameObject);
            Destroy(gameObject);
            SpawnPowerup.currentObjects = -1;
        }
    }
}
