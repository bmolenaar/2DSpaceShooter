using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreMaster : MonoBehaviour {

    public Text score;
    public static float masterScore = 0f;

	void Start ()
    {
       
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        gameObject.GetComponent<Text>().text = masterScore.ToString();

    }

    public static void Reset()
    {
        masterScore = 0f;
    }
}
