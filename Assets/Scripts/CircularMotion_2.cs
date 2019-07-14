using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CircularMotion_2 : MonoBehaviour {

    public float z; //光速に対する比率
    float v; //光時計の移動速度

    public float radius = 0.5f; //円の大きさ

    public GameObject spin; //回転させるオブジェクト

    float dx; //円運動のsin値
    float dz; //円運動のcos値

    float elapsedTime = 0.0f;

    //PhotonTranslateCompRotateスクリプトで参照する補正スピードを計算
    private void Start()
    {
        v = 2 * z;
    }

    void FixedUpdate()
    {
        elapsedTime += Time.deltaTime;
        dx = radius * Mathf.Sin(elapsedTime * v);
        dz = radius * Mathf.Cos(elapsedTime * v);

        spin.transform.position = new Vector3(dx, 0.0f, dz);

        //spin.transform.LookAt(this.gameObject.transform); //回転させるオブジェクトを常にこのオブジェクトに向かせる
        spin.transform.LookAt(Vector3.zero); //回転させるオブジェクトを常に原点に向かせる

    }

}
