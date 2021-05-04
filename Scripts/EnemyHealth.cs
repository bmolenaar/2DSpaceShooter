using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour {

    public float currentHealth;
    public float maxHealth;
    public float scoreGiven;
    public GameObject[] explosions;
    private int index;


    //////////SET CURRENT HEALTH AND RANDOMIZE EXPLOSION SPRITE//////////
    void Start ()
    {
        currentHealth = maxHealth;
        index = UnityEngine.Random.Range(0, explosions.Length);
    }


    void Update ()
    {
        DestroyEnemy();
	}

    //////////TAKE DAMAGE//////////
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag == "Bullet")
        {
            currentHealth -= OutputDamage.bulletDamage;
        }
    }


    //////////DESTROY ENEMY WHEN HEALTH IS GONE, CREATE EXPLOSIONS, ADD TO PLAYER SCORE AND KEEP TRACK OF HOW MANY ENEMIES HAVE BEEN DESTROYED//////////
    public void DestroyEnemy()
    {

        if (currentHealth <= 0)
        {
            Destroy(gameObject);
            Instantiate(explosions[index], gameObject.transform.position, transform.rotation);
            ScoreMaster.masterScore += scoreGiven;
            WaveMaster.enemiesDestroyed += 1;
        }
    }
}
