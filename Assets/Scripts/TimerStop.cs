using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimerStop : MonoBehaviour {

    public PlayerTimer playerTimer;
    public EarthTimer earthTimer;

    void TimerDisplayFreeze () {

        playerTimer.on = false;
        earthTimer.on = false;

    }
}
