using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TitleStartButton : MonoBehaviour {

    void Start()
    {
        Invoke("ChangeScene", 3f);
    }

    void ChangeScene()
    {
        SceneManager.LoadScene("PhotonClockTest");
    }

    /*
    public void OnClick()
    {
        SceneManager.LoadScene("PhotonClockTest");
    }*/
}
