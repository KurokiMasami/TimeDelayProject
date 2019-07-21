using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GotoIndexButton : MonoBehaviour {

    public AudioClip pushsound;
    AudioSource audioSource;

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Hand")
        audioSource.PlayOneShot(pushsound, 1.0F);
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
