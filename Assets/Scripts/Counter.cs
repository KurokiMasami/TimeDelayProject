using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Counter : MonoBehaviour {

    public TextMesh timerText; //Text用変数
    private int timer; //タイム計算用変数
    //public GameObject Top; //上面オブジェクト
    //public GameObject Under; //下面オブジェクト

    // Use this for initialization
    void Start () {
        timer = -1;
        SetTimer();   //初期タイムを代入して表示
    }
	


    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.CompareTag("Under"))
        {
            timer += 1;
        }

    SetTimer();

    }

    /*
    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject == Top || Under)
        {
            timer += 1;
        }

        SetTimer();

    }*/


    void SetTimer(){
        //timerText.text = string.Format("Time:{0}", timer);
        timerText.text = string.Format("{0}", timer);
    }
}
