using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {

    public GameObject followTarget;
    private Vector3 targetPos;
    public float followSpeed;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        //HitBoundary();

        if (followTarget != null)
        {
            targetPos = new Vector3(followTarget.transform.position.x, followTarget.transform.position.y, transform.position.z);
            transform.position = Vector3.Lerp(transform.position, targetPos, followSpeed);
        }
        else
        {
            followTarget = GameObject.Find("Player");
        }
    }

    //void HitBoundary()
    //{
    //    if (followTarget.transform.position.y > GameObject.Find("TopBoundary").transform.position.y)
    //    {
    //        transform.position = transform.position;
    //        followTarget = null;
    //    }
    //    else
    //    {
    //        followTarget = GameObject.Find("Player");
    //    }
    //}

}
