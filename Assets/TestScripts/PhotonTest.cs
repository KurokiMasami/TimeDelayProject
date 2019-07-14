using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PhotonTest : MonoBehaviour {

    public Vector3 velocityUp = new Vector3(0,1,0);
    public Vector3 velocityDown = new Vector3(0, -1, 0);
    private Vector3 velocity = Vector3.zero;

    //public Transform target;

    public float speed; // Speed in units per sec.
    //private Rigidbody rb;

    void Start()
    {
        //rb = GetComponent<Rigidbody>();
        //rb.velocity = velocityUp * speed;
        velocity = velocityUp;
    }

    // MoveTowardsのテスト
    /*
    void Update()
    {
        // The step size is equal to speed times frame time.
        float step = speed * Time.deltaTime;

        // Move our position a step closer to the target.
        transform.position = Vector3.MoveTowards(transform.position, target.position, step);

    }*/


    // 動かし方のテスト
    /*
    void Update()
    {
        //float dist = (target.position - transform.position).magnitude;
        //print("Distance to other: " + dist);

        //transform.position += speed * Time.deltaTime;

        //transform.Translate(velocityUp * Time.deltaTime * speed, Space.World);

    }*/




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
        Debug.Log("コリジョンに入ったよ"+ col.gameObject.name);

        if (col.gameObject.tag == "Top")
        {
            velocity = velocityDown;

            //rb.velocity = velocityDown * speed;
        }

        else if (col.gameObject.tag == "Under")
        {
            velocity = velocityUp;

            //rb.velocity = velocityUp * speed;
        }


    }


    // コルーチンを使ったテスト
    /*
    private void OnTriggerEnter(Collider other)
    {

        //Debug.Log("コリジョンに入ったよ"+other.gameObject.name);

        if (other.gameObject.tag == "Under")
        {
            StartCoroutine(MoveUp());
            StopCoroutine("MoveDown");
        }
        else if(other.gameObject.tag == "Top")
        {
            //Debug.Log("MoveDownに入った");
            StartCoroutine(MoveDown());
            StopCoroutine("MoveUp");
        }
            
    }


    private　IEnumerator MoveUp()
    {
        while (transform.position.y < 2)
        {
            Debug.Log("velocityUp"+ velocityUp);
            transform.Translate(velocityUp * Time.deltaTime * speed, Space.World);
            yield return null;
        }

    }

    private　IEnumerator MoveDown()
    {
        while (transform.position.y > 0)
        {
            Debug.Log("velocityDown"+ velocityDown);
            transform.Translate(velocityDown * Time.deltaTime * speed, Space.World);
            yield return null;
        }

    }
    */

}
