using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class Shoot : MonoBehaviour {

    public GameObject bullet;
    private Transform location;
    GameObject obj;
    bool allowFire = true;

    void Start ()
    {
        location = GameObject.Find("FollowTarget").transform;
    }
	
	void Update ()
    {
        if (CrossPlatformInputManager.GetButton("MobileJoystickRight") && allowFire == true)
        {
            StartCoroutine(Fire());
            Instantiate(bullet, location.position, location.rotation);
        }
    }


    IEnumerator Fire()
    {
        allowFire = false;
        yield return new WaitForSecondsRealtime(0.1f);
        allowFire = true;
    }
}
