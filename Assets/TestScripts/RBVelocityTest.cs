using UnityEngine;
using System.Collections;

public class RBVelocityTest : MonoBehaviour
{
    Rigidbody rb;
    public float speed;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    void FixedUpdate()
    {
        //if (Input.GetKeyDown(KeyCode.Space))
        rb.velocity = new Vector3(0, 1, 0) * Time.deltaTime * speed;
        Debug.Log(transform.position.y);
    }
}