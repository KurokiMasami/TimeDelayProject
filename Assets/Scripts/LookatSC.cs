using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookatSC : MonoBehaviour {

    public GameObject targetCamera;
    //readonly int COUNT = 100000;

    void Update () {

        this.transform.LookAt(targetCamera.transform);

        /*
        for (int i = 0; i < COUNT; i++)
        {
            Vector3 target = targetCamera.transform.position;
            target.y = this.transform.position.y;
            this.transform.LookAt(target);
        }*/
    }
}
