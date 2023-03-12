using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveScript : MonoBehaviour
{
    private float speed = 2;
    private float jumpForce = 5f;
    public bool OnGround = true;
    private Rigidbody playerRb;
    private float horizontalInput;
    private float verticalInput;
    public Transform EndPoint;
    void Start()
    {
        playerRb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        // transform.Translate(Vector3.forward *speed*Time.deltaTime);
        // transform.position = Vector3.MoveTowards(transform.position,EndPoint.position,Time.deltaTime*speed);
       
        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right*Time.deltaTime*speed*horizontalInput);
        verticalInput = Input.GetAxis("Vertical");
        transform.Translate(Vector3.forward*Time.deltaTime*speed*verticalInput);

        if(Input.GetKeyDown(KeyCode.Space)){
            playerRb.AddForce(Vector3.up*jumpForce,ForceMode.Impulse);
        }
    }
}
