using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonSwap : MonoBehaviour {

    public GameObject playButton;
    public GameObject returnButton;
    public GameObject DescriptionText;

    //MeshRenderer play_mr;
    //MeshRenderer return_mr;

    void Start () {

        //play_mr = playButton.GetComponent<MeshRenderer>();
        //return_mr = returnButton.GetComponent<MeshRenderer>();

        playButton.SetActive(true);
        returnButton.SetActive(false);

    }
	
	void ButtonObjSwap()
    {
        //play_mr.material.color = new Color(0, 0, 0, 0.0f);
        //return_mr.material.color = new Color(0, 0, 0, 1.0f);

        playButton.SetActive(false);
        returnButton.SetActive(true);

        DescriptionText.SetActive(false);

    }
}
