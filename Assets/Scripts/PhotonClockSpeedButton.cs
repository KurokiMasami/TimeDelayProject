using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PhotonClockSpeedButton : MonoBehaviour {

    public PhotonClockZControl zControl; //共通使用するマスターz（移動速度の光速に対する比率）参照用変数
    public float percentage;


    public void OnClick()
    {
        zControl.master_z = percentage; //インスペクタで設定した割合をマスターzに代入
    }

}
