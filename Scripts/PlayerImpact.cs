using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerImpact : MonoBehaviour {

    private int lives = 50;
    private List<GameObject> playerLives;
    private SpriteRenderer sprRend;
    private PolygonCollider2D col2D;
    private Canvas deathCanvas;
    private GameObject shootButton;

	void Start ()
    {
        //Set the played to have 3 lives
        playerLives = new List<GameObject>();
        playerLives.AddRange(GameObject.FindGameObjectsWithTag("Lives"));
        //Get references to the player sprite and the UI canvas objects
        sprRend = GetComponent<SpriteRenderer>();
        col2D = GetComponent<PolygonCollider2D>();
        deathCanvas = GameObject.Find("DeathCanvas").GetComponent<Canvas>();
        shootButton = GameObject.Find("MobileJoystickRight");
    }

    // Update is called once per frame
    void Update ()
    {
        //If out of lives, show retry button and pause time
        if (lives <= 0)
        {
            shootButton.GetComponent<Shoot>().enabled = false;
            deathCanvas.enabled = true;
            if (Time.timeScale == 1)
            {
                Time.timeScale = 0;
            }
           
        }
        //If I'm still alive, allow me to move/shoot
        else
        {
            shootButton.GetComponent<Shoot>().enabled = true;
            gameObject.GetComponent<PlayerMove>().enabled = true;
            deathCanvas.enabled = false;
            Time.timeScale = 1;
        }
    }

    //If I get hit by an enemy or by an enemy projectile, remove a life and destroy one of my lives in the top left corner
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag == "Enemy" || collision.collider.tag == "EnemyBullet")
        {
            if (lives > 0)
            {
                lives -= 1;
                Destroy(playerLives[0]);
            }            
            
            playerLives.RemoveAt(0);
            StartCoroutine(onImpact(0.1f));
        }
    }

    //Blink sprite and disable collider when I get hit
    IEnumerator onImpact(float time)
    {
        for (int i = 0; i < 10; i++)
        {
            sprRend.enabled = false;
            col2D.enabled = false;
            yield return new WaitForSecondsRealtime(time);
            sprRend.enabled = true;
            yield return new WaitForSecondsRealtime(time);
        }
        col2D.enabled = true;
    }
}
