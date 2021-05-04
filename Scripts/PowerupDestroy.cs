using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerupDestroy : MonoBehaviour {

    private void Update()
    {
        var playerPos = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>().transform.position;
        var heading = gameObject.transform.position - playerPos;
        if (heading.x >= 50 || heading.y >= 50 || heading.x <= -50 || heading.y <= -50)
        {
            Destroy(gameObject);
            SpawnPowerup.currentObjects -= 1;
        }
    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag == "Player")
        {
            Destroy(gameObject);
            SpawnPowerup.currentObjects -= 1;
        }
    }

}
