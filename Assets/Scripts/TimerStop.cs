using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimerStop : MonoBehaviour {

    public PlayerTimer playerTimer;
    public EarthTimer earthTimer;
    public EarthTimer earthTimer2;

    void TimerDisplayFreeze () {

        playerTimer.on = false;
        earthTimer.on = false;
        earthTimer2.on = false;

    }
}
