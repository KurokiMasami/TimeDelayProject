using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PhotonClockStartButton : MonoBehaviour
{
    public GameObject staticPhoton;
    public GameObject moveStraightPhoton;
    public GameObject moveRotatePhoton;
    public GameObject circularMotion;

    private void Start()
    {
        staticPhoton.GetComponent<PhotonTranslateComp>().enabled = false;
        moveStraightPhoton.GetComponent<PhotonTranslateComp>().enabled = false;
        moveRotatePhoton.GetComponent<PhotonTranslateCompRotate>().enabled = false;
        circularMotion.GetComponent<CircularMotion>().enabled = false;
        //moveRotatePhoton.GetComponent<PhotonTranslateCompRotate_2>().enabled = false;
        //circularMotion.GetComponent<CircularMotion_2>().enabled = false;
    }
    public void OnClick()
    {
        staticPhoton.GetComponent<PhotonTranslateComp>().enabled = true;
        moveStraightPhoton.GetComponent<PhotonTranslateComp>().enabled = true;
        moveRotatePhoton.GetComponent<PhotonTranslateCompRotate>().enabled = true;
        circularMotion.GetComponent<CircularMotion>().enabled = true;
        //moveRotatePhoton.GetComponent<PhotonTranslateCompRotate_2>().enabled = true;
        //circularMotion.GetComponent<CircularMotion_2>().enabled = true;
    }
}
