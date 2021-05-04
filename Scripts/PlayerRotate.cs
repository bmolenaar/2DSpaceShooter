using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class PlayerRotate : MonoBehaviour {

    float dirX, dirY;
    public static float rotateAngle;

    void Start () {
		
	}
	

	void Update () {
		
	}

    void Rotate()
    {
        dirX = -Mathf.RoundToInt(CrossPlatformInputManager.GetAxis("Horizontal"));
        dirY = -Mathf.RoundToInt(CrossPlatformInputManager.GetAxis("Vertical"));

        if (dirX == 0 && dirY == 1)
        {
            rotateAngle = 0;
        }

        if (dirX == 1 && dirY == 1)
        {
            rotateAngle = -45f;
        }

        if (dirX == 1 && dirY == 0)
        {
            rotateAngle = -90f;
        }

        if (dirX == 1 && dirY == -1)
        {
            rotateAngle = -135f;
        }

        if (dirX == 0 && dirY == -1)
        {
            rotateAngle = -180f;
        }

        if (dirX == -1 && dirY == -1)
        {
            rotateAngle = -225f;
        }

        if (dirX == -1 && dirY == 0)
        {
            rotateAngle = -270f;
        }

        if (dirX == -1 && dirY == 1)
        {
            rotateAngle = -315f;
        }

        if (dirX == 0 && dirY == 0)
        {
            rotateAngle = rotateAngle;
        }

        transform.rotation = Quaternion.Euler(0f, 0f, rotateAngle);

    }
}
