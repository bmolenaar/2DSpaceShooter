using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyEnemyBullet : MonoBehaviour {

    private Rigidbody2D rigid2D;
    private PolygonCollider2D col2D;

	void Start ()
    {
        Destroy(gameObject, 1);
        rigid2D = gameObject.GetComponent<Rigidbody2D>();
        col2D = gameObject.GetComponent<PolygonCollider2D>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag == "Player")
        {
            Destroy(gameObject);
        }

        if (collision.collider.tag == "Enemy" || collision.collider.tag == "EnemyBullet" || collision.collider.tag == "Bullet")
        {
            StartCoroutine(DisableBullet());
        }

    }

    IEnumerator DisableBullet()
    {
        col2D.enabled = false;
        yield return new WaitForSecondsRealtime(0.1f);
        col2D.enabled = true;
    }
}
