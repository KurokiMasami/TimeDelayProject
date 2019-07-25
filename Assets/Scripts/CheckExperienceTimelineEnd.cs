using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.SceneManagement;
public class CheckExperienceTimelineEnd : MonoBehaviour
{
    /*
    private PlayableDirector playableDirector;
    //　終了を検知したかどうか
    private bool isEnd;

    public Canvas MenuCanvas;
    public Canvas ReturnCanvas;
    //public GameObject DescriptionTextCanvas;
    CanvasGroup menuCV;
    CanvasGroup returnCV;

    void Start()
    {
        playableDirector = GetComponent<PlayableDirector>();
        isEnd = false;

        menuCV = MenuCanvas.GetComponent<CanvasGroup>();
        returnCV = ReturnCanvas.GetComponent<CanvasGroup>();
    }

    void Update()
    {
        //　タイムラインが終了したらCanvasを表示する
        if (!isEnd && playableDirector.state != PlayState.Playing)
        {
            isEnd = true;
            menuCV.alpha = 1;
            returnCV.alpha = 1;
            //DescriptionTextCanvas.SetActive(false);
        }
    }*/

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
            SceneManager.LoadScene("ExperienceTitle");
        }
    }
}
