using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddForce : MonoBehaviour {


    private Rigidbody2D rigid2D;

	void Start ()
    {
        rigid2D = gameObject.GetComponent<Rigidbody2D>();

        rigid2D.AddForce(-transform.up * 10);
	}
	
	void Update ()
    {
		
	}
}
