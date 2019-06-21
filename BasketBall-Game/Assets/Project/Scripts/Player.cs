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

    // Start is called before the first frame update
    void Start()
    {
        ball.GetComponent<Rigidbody>().useGravity = false;        
    }

    void FixedUpdate()
    {
        ball.transform.position = playerCamera.transform.position + (playerCamera.transform.forward * ballOffSet);
    }
}
