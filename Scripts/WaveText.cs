using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WaveText : MonoBehaviour {

	void Start ()
    {
    }
	
	void Update ()
    {
        gameObject.GetComponent<Text>().text = "Wave: " + WaveMaster.wave.ToString();
    }
}
