using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PhotonTranslateComp : MonoBehaviour {

    public float z; //移動速度の光速に対する比率
    float v; //光時計の移動速度

    float x; //光子が進むベクトルのx成分
    float y = 1; //光子が進むベクトルのy成分

    Vector3 velocityUp; //上向きの時のベクトル
    Vector3 velocityDown; //下向きの時のベクトル
    Vector3 velocity = Vector3.zero; //光子移動時に呼ぶベクトル変数

    Vector3 velocitySide; //光時計の移動（横向き）ベクトル

    float distance; //光子が進む距離

    public float photonSpeed = 2; // 光の速度（m/s）
    float speedConversion; //補正スピード

    public GameObject Top; //上面オブジェクト
    public GameObject Under; //下面オブジェクト
    public GameObject Case; //ケースオブジェクト
    public GameObject Counter; //カウンターオブジェクト
    public GameObject CounterText; //カウンターテキストオブジェクト

    public AudioClip pushsound;
    AudioSource audioSource;

    void Start()
    {
        v = photonSpeed * z;
        x = Mathf.Sqrt(-Mathf.Pow(v, 2) / (Mathf.Pow(v, 2)- Mathf.Pow(photonSpeed, 2)));
        //Debug.Log("x=" + x);

        velocityUp = new Vector3(x, y, 0);
        velocityDown = new Vector3(x, -y, 0);
        velocitySide = new Vector3(1, 0, 0);

        distance = Mathf.Sqrt(Mathf.Pow(x, 2) + Mathf.Pow(y, 2));
        speedConversion = photonSpeed / distance;

        velocity = velocityUp;

        audioSource = GetComponent<AudioSource>();
    }

    void Update()
    {
        // アップデートで処理する場合
        /*
        if (transform.position.y >= 2)
        {
            velocity = velocityDown;

        }
        else if(transform.position.y <= 0)
        {
            velocity = velocityUp;
        }*/

        this.transform.Translate(velocity * Time.deltaTime * speedConversion);
        Top.transform.Translate(velocitySide * Time.deltaTime * v);
        Under.transform.Translate(velocitySide * Time.deltaTime * v);
        Case.transform.Translate(velocitySide * Time.deltaTime * v);
        Counter.transform.Translate(velocitySide * Time.deltaTime * v);
        CounterText.transform.Translate(velocitySide * Time.deltaTime * v);

    }


    // 当たり判定で処理する場合


    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Top")
        {
            velocity = velocityDown;
            //Debug.Log("Top");
        }

        else if (col.gameObject.tag == "Under")
        {
            velocity = velocityUp;
            //Debug.Log("Under");
            audioSource.PlayOneShot(pushsound, 0.5F);
        }

    }
}
