using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SelectPhotonClockButton : MonoBehaviour {

    public void OnClick()
    {
        SceneManager.LoadScene("PhotonClock");
    }
}
