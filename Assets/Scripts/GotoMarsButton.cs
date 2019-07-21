using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GotoMarsButton : MonoBehaviour {

    public AudioClip pushsound;
    AudioSource audioSource;

    public PlayerTimer playerTimer;
    public EarthTimer earthTimer;
    public Animator ArrowAnim;

    public GameObject parentObj;
    public GameObject childObj;

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
        playerTimer.enabled = false;
        earthTimer.enabled = false;
        ArrowAnim.SetBool("ArrowAnim_moon", false);
        ArrowAnim.SetBool("ArrowAnim_mars", false);
    }

    private void OnTriggerEnter(Collider col)
        {
        if(col.gameObject.tag == "Hand")
            audioSource.PlayOneShot(pushsound, 1.0F);
            playerTimer.enabled = true;
            earthTimer.enabled = true;
            ArrowAnim.SetBool("ArrowAnim_mars", true);

            childObj.transform.parent = parentObj.transform;
    }

    /*
    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "hand")
        {
            audioSource.PlayOneShot(pushsound, 1.0F);
            playerTimer.enabled = true;
            earthTimer_moon.enabled = true;
            ArrowAnim_moon.SetBool("ArrowAnim_moon", true);
            
            childObj.transform.parent = parentObj.transform;          
        }
    }*/

    /*
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            playerTimer.enabled = true;
            earthTimer_moon.enabled = true;
            ArrowAnim_moon.SetBool("ArrowAnim_moon", true);

            childObj.transform.parent = parentObj.transform;
        }
    }*/

}
