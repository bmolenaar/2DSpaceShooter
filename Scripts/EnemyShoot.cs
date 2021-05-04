using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShoot : MonoBehaviour {

    public GameObject bullet;
    private bool allowFire = true;
    public Transform location;

	void Start ()
    {
        //location = GameObject.Find("LookAt").transform;
	}
	
	void Update ()
    {
        if (allowFire == true && Time.timeScale != 0)
        {
            StartCoroutine(AllowFire());
            Instantiate(bullet, location.position, location.transform.rotation);
        }
	}

    IEnumerator AllowFire()
    {
        allowFire = false;
        yield return new WaitForSecondsRealtime(2f);
        allowFire = true;
    }

}
