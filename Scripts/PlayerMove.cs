using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class PlayerMove : MonoBehaviour {

    float dirX, dirY, rightsideX, rightsideY;
    public static float rotateAngle;
    public float moveSpeed;
    private GameObject topBoundary,bottomBoundary, leftBoundary, rightBoundary;

	void Start ()
    {
        gameObject.transform.rotation = new Quaternion(0, 0, 180, 0);
        rotateAngle = 180f;
        topBoundary = GameObject.Find("TopBoundary");
        bottomBoundary = GameObject.Find("BottomBoundary");
        leftBoundary = GameObject.Find("LeftBoundary");
        rightBoundary = GameObject.Find("RightBoundary");
	}
	
	void Update ()
    {
        Move();
        Rotate();
    }

    void Rotate()
    {
        //LEFT STICK SET DIRECTION AXIS
        dirX = -Mathf.RoundToInt(CrossPlatformInputManager.GetAxis("Horizontal"));
        dirY = -Mathf.RoundToInt(CrossPlatformInputManager.GetAxis("Vertical"));


        Vector3 lookVec = new Vector3(CrossPlatformInputManager.GetAxis("H"), CrossPlatformInputManager.GetAxis("V"), 2147);

        if (lookVec.x !=0 && lookVec.y != 0)
        {
            transform.rotation = Quaternion.LookRotation(lookVec, -Vector3.back);
        }

    }

    void Move()
    {
        transform.position = new Vector2(-dirX * moveSpeed * Time.deltaTime
            + transform.position.x, -dirY * moveSpeed * Time.deltaTime + transform.position.y);
    }


}
