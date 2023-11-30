using System.Collections;
using System.Collections.Generic;
using UnityEditor.AnimatedValues;
using UnityEngine;

public class BallController : MonoBehaviour
{
    [SerializeField] public int force;

    Rigidbody ball;

    private int count;
    private bool xAxis = false;
    private bool yAxis = false;
    private bool isGrounded;

    void Start()
    {
        ball = GetComponent<Rigidbody>();
    }
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if (xAxis == false)
            {
                xAxis = true;
                yAxis = false;
            }
            else
            {
                yAxis = true;
                xAxis = false;
                count = 1;
            }

            if (xAxis == true)
            {
                ball.AddForce(transform.right * force, ForceMode.Force);
                if (count != 0)
                {
                    ball.AddForce(-transform.forward * force, ForceMode.Force);
                }
            }

            if (yAxis == true)
            {
                ball.AddForce(transform.forward * force, ForceMode.Force);
                ball.AddForce(-transform.right * force, ForceMode.Force);
            }

        }

        Gravity();
    }

    void Gravity()
    {
        isGrounded = Physics.Raycast(transform.position, -Vector3.up, GetComponent<Collider>().bounds.extents.y);

        if (!isGrounded)
        {
            ball.useGravity = true;
        }
    }
}
