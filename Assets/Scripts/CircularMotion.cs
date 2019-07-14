using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;

public class CircularMotion : MonoBehaviour {

    /*変数zでプロパティを使用する場合の書き方
    private int z;
    public int Z
    {
        get { return z; }
        set { z = value; }
    }*/

    public PhotonClockZControl zControl; //共通使用するマスターz（移動速度の光速に対する比率）参照用変数

    float z; //移動速度の光速に対する比率
    float v; //光時計の移動速度

    float x; //光子が進むベクトルのx成分
    float y = 1; //光子が進むベクトルのy成分

    float distance; //光子が進む距離

    float speed = 2; // 光の速度（m/s）
    public float speedConversionControl; //補正スピード



    public float radius = 0.5f; //円の大きさ

    public GameObject spin; //回転させるオブジェクト

    float dx; //円運動のsin値
    float dz; //円運動のcos値

    float elapsedTime = 0.0f; //経過時間を入れる変数

    Vector3 position;

    //PhotonTranslateCompRotateスクリプトで参照する補正スピードを計算
    void Start()
    {
        z = zControl.master_z; //Buttonクリックにより設定済みのマスターzを取得し、zに代入
        v = 2 * z;
        x = Mathf.Sqrt(-Mathf.Pow(v, 2) / (Mathf.Pow(v, 2) - 4));
        Debug.Log("x=" + x);

        distance = Mathf.Sqrt(Mathf.Pow(x, 2) + Mathf.Pow(y, 2));
        speedConversionControl = speed / distance;

        position = InputTracking.GetLocalPosition(XRNode.CenterEye);
    }


    void FixedUpdate()
    {
        elapsedTime += Time.deltaTime;
        dx = radius * Mathf.Sin(elapsedTime * v);
        dz = radius * Mathf.Cos(elapsedTime * v);

        spin.transform.position = new Vector3(dx, 0.5f, dz);

        spin.transform.LookAt(this.gameObject.transform); //回転させるオブジェクトを常にこのオブジェクトに向かせる
        //spin.transform.LookAt(Vector3.zero); //回転させるオブジェクトを常に原点に向かせる


    }

}
