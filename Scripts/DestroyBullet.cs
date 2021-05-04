using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyBullet : MonoBehaviour {

    private void Start()
    {
        Destroy(gameObject, 1);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag != "Shield" || collision.collider.tag == "Bullet")
        {
            Destroy(gameObject);
        }

    }
}
