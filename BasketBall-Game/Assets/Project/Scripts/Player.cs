using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [Header("game Object varialbles:")]
    public GameObject ball;
    public GameObject playerCamera;

    [Space]
    [Header("Some public variables:")]
    public float ballOffSet;
    public float ballThrowingForce;

    // some private variables
    public bool isHoldingBall = true;


    // Start is called before the first frame update
    void Start()
    {
        ball.GetComponent<Rigidbody>().useGravity = false;
    }

    void FixedUpdate()
    {
        if (isHoldingBall)
        {
            ball.transform.position = playerCamera.transform.position + (playerCamera.transform.forward * ballOffSet);
            if (Input.GetMouseButtonDown(0))
            {
                isHoldingBall = false;
                ball.GetComponent<Rigidbody>().useGravity = true;

                ball.GetComponent<Rigidbody>().AddForce(playerCamera.transform.forward * ballThrowingForce);
            }
        }
    }
}
