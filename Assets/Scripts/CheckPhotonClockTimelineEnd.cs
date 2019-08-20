using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.SceneManagement;
public class CheckPhotonClockTimelineEnd : MonoBehaviour
{

    private PlayableDirector playableDirector;
    //　終了を検知したかどうか
    private bool isEnd;

    //public Canvas moveControlCanvas;
    //CanvasGroup CV;

    void Start()
    {
        playableDirector = GetComponent<PlayableDirector>();
        isEnd = false;

        //CV = moveControlCanvas.GetComponent<CanvasGroup>();
        //CV.alpha = 0;

    }

    void Update()
    {
        //　タイムラインが終了したら本編シーンを読み込む
        if (!isEnd && playableDirector.state != PlayState.Playing)
        {
            isEnd = true;
            SceneManager.LoadScene("PhotonClockDescription_02");
        }

        //　タイムラインが終了したらスタートボタンを表示する
        /*if (!isEnd && playableDirector.state != PlayState.Playing)
        {
            isEnd = true;
            CV.alpha = 1;
        }*/
    }
}
