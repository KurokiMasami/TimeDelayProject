using UnityEngine;
using System.Collections;

public class MovePositionTest : MonoBehaviour
{
    public Vector3 teleportPoint;
    Rigidbody rb;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    void FixedUpdate()
    {
        rb.MovePosition(transform.position + transform.forward * Time.deltaTime);
    }
}