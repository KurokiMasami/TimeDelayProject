using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PhotonClockSpeedButton : MonoBehaviour {

    public PhotonClockZControl zControl; //共通使用するマスターz（移動速度の光速に対する比率）参照用変数
    public float percentage;

    public Canvas moveControlCanvas;
    CanvasGroup thisCV;
    CanvasGroup otherCV;

    private void Start()
    {
        thisCV = GetComponentInParent<CanvasGroup>();
        otherCV = moveControlCanvas.GetComponent<CanvasGroup>();
    }


    public void OnClick()
    {
        StartCoroutine("DisplaySwitch");
    }

    private IEnumerator DisplaySwitch()
    {
        zControl.master_z = percentage; //インスペクタで設定した割合をマスターzに代入
        yield return new WaitForSeconds(0.5f);
        thisCV.alpha = 0;
        yield return new WaitForSeconds(0.5f);
        otherCV.alpha = 1;
    }
}
