using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PhotonClockPauseButton : MonoBehaviour {

    public void OnClick()
    {
        if (Time.timeScale == 0)
        {
            Time.timeScale = 1;
        }
        else if (Time.timeScale == 1)
        {
            Time.timeScale = 0;
        }

    }
}
