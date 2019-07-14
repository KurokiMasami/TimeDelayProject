using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PhotonClockSet : MonoBehaviour {

	// Use this for initialization
	void Awake () {
        if (Time.timeScale == 0)
        {
            Time.timeScale = 1;
        }
    }
	
}
