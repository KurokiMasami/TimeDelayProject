using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SelectExperienceButton : MonoBehaviour {

    public void OnClick()
    {
        SceneManager.LoadScene("ExperienceTitle");
    }
}
