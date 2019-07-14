using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimerStop : MonoBehaviour {

    public PlayerTimer playerTimer;
    public EarthTimer_moon earthTimer_moon;

    void TimerDisplayFreeze () {

        playerTimer.on = false;
        earthTimer_moon.on = false;

    }
}
