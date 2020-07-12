using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarMovement : MonoBehaviour
{
    public bool move = true;

    private Rigidbody parentBody;
    public Rigidbody body;

    private Vector3 movementVector;

    public float acceleration = 10f;
    public float rotationSpd = 0.5f;

    private float movementDirection;
    private float strafeDirection;

    private float currentSpd;
    private int isMoving;

    private void Start()
    {
        movementVector = Vector3.zero;
    }

    private void FixedUpdate()
    {
        if (move) { transform.Translate(Vector3.forward * 0.05f); }

        body.AddRelativeForce(Vector3.forward * acceleration * movementDirection);
        body.AddRelativeForce(Vector3.right * acceleration * strafeDirection);
    }

    public void SetAcceleration(float inputValue)
    {
        movementDirection = inputValue;
    }

    public void SetRotation(float inputValue)
    {
        strafeDirection = inputValue;
    }
}
