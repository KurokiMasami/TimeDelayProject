using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PhotonTranslate : MonoBehaviour {

    public Vector3 velocityUp = new Vector3(0,1,0);
    public Vector3 velocityDown = new Vector3(0, -1, 0);
    private Vector3 velocity = Vector3.zero;

    public float speed; // Speed in units per sec.

    void Start()
    {
        velocity = velocityUp;
    }

    void FixedUpdate()
    {
        // アップデートで処理する場合
        /*
        if (transform.position.y >= 2)
        {
            velocity = velocityDown;

        }
        else if(transform.position.y <= 0)
        {
            velocity = velocityUp;
        }*/

        transform.Translate(velocity * Time.deltaTime * speed, Space.World);

    }


    // 当たり判定で処理する場合

    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Top")
        {
            velocity = velocityDown;
        }

        else if (col.gameObject.tag == "Under")
        {
            velocity = velocityUp;
        }


    }

    }
