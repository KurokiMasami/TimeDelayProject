using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SelectExperienceDescriptionButton : MonoBehaviour {

    public void OnClick()
    {
        SceneManager.LoadScene("ExperienceTitleDescription");
    }
}
