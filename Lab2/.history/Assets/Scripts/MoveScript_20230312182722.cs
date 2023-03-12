using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveScript : MonoBehaviour
{
    private float speed = 2;
    private float jumpForce = 5f;
    public bool onGround = true;
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
        
        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right*Time.deltaTime*speed*horizontalInput);
        verticalInput = Input.GetAxis("Vertical");
        transform.Translate(Vector3.forward*Time.deltaTime*speed*verticalInput);

        if(Input.GetKeyDown(KeyCode.Space) && onGround==true){
            playerRb.AddForce(Vector3.up*jumpForce,ForceMode.Impulse);
            onGround=false;
        }
    }
    private void OnCollisionEnter(Collision other) {
        if(other.gameObject.CompareTag("Ground")){
            onGround=true;

        }
    }
}
