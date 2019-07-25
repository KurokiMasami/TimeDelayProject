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

    void Start()
    {
        playableDirector = GetComponent<PlayableDirector>();
        isEnd = false;

    }

    void Update()
    {
        //　タイムラインが終了したら本編シーンを読み込む
        if (!isEnd && playableDirector.state != PlayState.Playing)
        {
            isEnd = true;
            SceneManager.LoadScene("PhotonClock");
        }
    }
}
