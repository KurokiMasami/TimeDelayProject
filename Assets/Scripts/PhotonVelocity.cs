using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PhotonVelocity : MonoBehaviour {

    public Vector3 velocityUp = new Vector3(0,1,0);
    public Vector3 velocityDown = new Vector3(0, -1, 0);

    public float speed; // Speed in units per sec.
    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.velocity = velocityUp * speed;
    }

    void FixedUpdate()
    {
        // アップデートで処理する場合
        /*
        if (transform.position.y >= 2)
        {
            rb.velocity = velocityDown * speed;

        }
        else if(transform.position.y <= 0)
        {
            rb.velocity = velocityUp * speed;
        }*/

    }


    // 当たり判定で処理する場合

    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Top")
        {
            rb.velocity = velocityDown * speed;
        }

        else if (col.gameObject.tag == "Under")
        {
            rb.velocity = velocityUp * speed;
        }


    }

    }
