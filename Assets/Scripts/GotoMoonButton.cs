using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GotoMoonButton : MonoBehaviour {

    public AudioClip pushsound;
    AudioSource audioSource;

    public PlayerTimer playerTimer;
    public EarthTimer_moon earthTimer_moon;
    public Animator ArrowAnim_moon;

    public GameObject parentObj;
    public GameObject childObj;

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
        playerTimer.enabled = false;
        earthTimer_moon.enabled = false;
        ArrowAnim_moon.SetBool("ArrowAnim_moon", false);
    }

    /*
    void OnCollosionEnter(Collision col)
    {
        if (col.gameObject.tag == "hand")
        {
            audioSource.PlayOneShot(pushsound, 1.0F);
            playerTimer.enabled = true;
            earthTimer_moon.enabled = true;
            ArrowAnim_m.SetBool("ArrowAnim_moon", true);
            
            childObj.transform.parent = parentObj.transform;          
        }
    }*/


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            playerTimer.enabled = true;
            earthTimer_moon.enabled = true;
            ArrowAnim_moon.SetBool("ArrowAnim_moon", true);

            childObj.transform.parent = parentObj.transform;
        }
    }

}
