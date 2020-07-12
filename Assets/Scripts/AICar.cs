using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AICar : MonoBehaviour
{
    private Rigidbody body;

    public float limiter = 0.2f;
    public float acceleration = 15f;

    private void Start()
    {
        body = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        //body.MovePosition(transform.position + transform.forward * limiter);
        body.AddRelativeForce(Vector3.forward * acceleration);
    }

    

    private void OnCollisionEnter(Collision collision)
    {
        if (!collision.gameObject.CompareTag("Destroyer")) { return; }
        Destroy(this.gameObject);
    }
}
