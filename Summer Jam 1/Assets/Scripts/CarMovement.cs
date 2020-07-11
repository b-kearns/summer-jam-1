using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarMovement : MonoBehaviour
{
    private Rigidbody body;

    private Vector3 movementVector;

    public float acceleration = 10f;
    public float rotationSpd = 0.5f;

    private float movementDirection;
    private float rotationDirection;

    private float currentSpd;
    private int isMoving;

    private void Start()
    {
        body = GetComponent<Rigidbody>();
        movementVector = Vector3.zero;
    }

    private void FixedUpdate()
    {
        body.AddRelativeForce(Vector3.forward * movementDirection * acceleration);

        if (body.velocity.magnitude != 0) { transform.Rotate(Vector3.up * rotationDirection * rotationSpd); }
    }

    public void SetAcceleration(float inputValue)
    {
        movementDirection = inputValue;
    }

    public void SetRotation(float inputValue)
    {
        rotationDirection = inputValue;
    }
}
