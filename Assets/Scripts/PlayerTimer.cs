using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PlayerTimer : MonoBehaviour {

    private int minute;
    private float seconds;
    //　前のUpdateの時の秒数
    //private float oldSeconds;
    //　タイマー表示用テキスト
    [SerializeField]
    private TextMeshPro timerText;
    public bool on = true;

    void Start()
    {
        minute = 0;
        seconds = 0f;
        //oldSeconds = 0f;
    }

    void FixedUpdate()
    {
        seconds += Time.deltaTime;
        if (seconds >= 60f)
        {
            minute++;
            seconds = seconds - 60;
        }

        if (on == true)
        {
            timerText.text = minute.ToString("00") + ":" + seconds.ToString("00.0");
        }
        else if (on == false)
        {
            timerText.text = timerText.text;
        }

        /*　値が変わった時だけテキストUIを更新
        if ((int)seconds != (int)oldSeconds)
        {
            timerText.text = minute.ToString("00") + ":" + seconds.ToString("f2");
        }
        oldSeconds = seconds;
        */

    }
}
