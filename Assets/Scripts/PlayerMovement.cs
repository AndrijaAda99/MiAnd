using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [Header("Movement")]
    public float moveSpeed = 10f;
    
    public float movementMultiplier = 10f;
    public float rigidbodyDrag = 6f;

    float horizontalMovement;
    float verticalMovement;

    Vector3 moveDirection;

    Rigidbody rigidbody;

    // Start is called before the first frame update
    void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
        rigidbody.freezeRotation = true;
    }

    // Update is called once per frame
    void Update()
    {
        MyInput();
        ControlDrag();
    }

    void MyInput()
    {
        horizontalMovement = Input.GetAxisRaw("Horizontal");
        verticalMovement = Input.GetAxisRaw("Vertical");

        moveDirection = transform.forward * verticalMovement + transform.right * horizontalMovement;
    }

    void ControlDrag()
    {
        rigidbody.drag = rigidbodyDrag ;
    }

    void FixedUpdate()
    {
        MovePlayer();
    }

    void MovePlayer()
    {
        rigidbody.AddForce(moveDirection.normalized * moveSpeed * movementMultiplier, ForceMode.Acceleration);
    }

    void OnCollisionEnter(Collision other)
    {
        Debug.Log("Detected");
    }
}
