using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyImpact : MonoBehaviour {

    public GameObject[] explosions;
    private int index;

    private void Start()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        index = UnityEngine.Random.Range(0, explosions.Length);


        if (collision.collider.tag == "Player")
        {
            Destroy(gameObject);
            Instantiate(explosions[index], gameObject.transform.position, transform.rotation);
        }

        

    }

}
