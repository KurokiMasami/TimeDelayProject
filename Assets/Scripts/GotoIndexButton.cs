using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GotoIndexButton : MonoBehaviour {


    private void OnTriggerEnter(Collider other)
    {
       SceneManager.LoadScene("ExperienceTitle");
    }

    /*
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Tab))
        {
            SceneManager.LoadScene("ExperienceTitle");
        }
    }*/

}
