using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Playables;

public class CounterTimerStop : MonoBehaviour {

    public TextMesh timerText; //Text用変数
    private int timer; //タイム計算用変数
    //public GameObject Top; //上面オブジェクト
    //public GameObject Under; //下面オブジェクト

    public int stopTime; //解説用に動きを止めるための時間指定
    public GameObject firstCanvas;
    public GameObject secondCanvas;
    //public PlayableDirector playableDirector;

    void Start () {
        timer = -1;
        SetTimer();   //初期タイムを代入して表示

        Animator animator = secondCanvas.GetComponent<Animator>();
        animator.updateMode = AnimatorUpdateMode.UnscaledTime;
    }
	


    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.CompareTag("Under"))
        {
            timer += 1;
        }

    SetTimer();

    }

    void SetTimer(){
        //timerText.text = string.Format("Time:{0}", timer);
        timerText.text = string.Format("{0}", timer);
    }

    private void Update()
    {
        if(timer == stopTime)
            StartCoroutine("DescriptionDisplaySwitch");
            //playableDirector.Play();

    }

    private IEnumerator DescriptionDisplaySwitch()
    {
        Time.timeScale = 0;
        yield return null;
        firstCanvas.SetActive(false);
        yield return null;
        secondCanvas.SetActive(true);

    }
}
