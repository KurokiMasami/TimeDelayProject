using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EarthTimer : MonoBehaviour {

    private int minute;
    private float seconds;
    //　前のUpdateの時の秒数
    //private float oldSeconds;
    //　タイマー表示用テキスト
    [SerializeField]
    private TextMesh timerText;
    public bool on = true;

    [SerializeField]
    float playerTime = 0;
    [SerializeField]
    float earthTime = 0;
    float ratio;

    void Start()
    {
        minute = 0;
        seconds = 0f;
        //oldSeconds = 0f;

        ratio = earthTime / playerTime;
    }

    void FixedUpdate()
    {
        seconds += Time.deltaTime * ratio;
        if (seconds >= 60f)
        {
            minute++;
            seconds = seconds - 60;
        }

        if (on == true)
        {
            timerText.text = "Earth "+ "\n" + minute.ToString("00") + ":" + seconds.ToString("00.0");
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
