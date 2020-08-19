using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BrackeysPlayerMovement : MonoBehaviour
{

    public CharacterController controller;
    public float speed = 15f;
    public float gravity = -9.81f;
    public float jumpHeight = 3f;
    Vector3 velocity;

    public Transform groundCheck;
    public float groundDistance = 0.4f;
    public LayerMask groundMask;
    bool isGrounded;
    bool inFixedMode = false;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("left shift")) {
            inFixedMode = !inFixedMode;
        }

        if (!inFixedMode) {
            // Reset velocity if player is grounded
            isGrounded = Physics.CheckSphere(groundCheck.position, groundDistance, groundMask);

            if (isGrounded && velocity.y < 0) {
                velocity.y = -2f;
            }

            // Player input
            float x = Input.GetAxis("Horizontal");
            float z = Input.GetAxis("Vertical");

            Vector3 move = transform.right * x + transform.forward * z;

            controller.Move(move * speed * Time.deltaTime);

             //Jumping
            if (Input.GetButtonDown("Jump") && isGrounded) {
                velocity.y = Mathf.Sqrt(jumpHeight * -2f * gravity);
            }

            // Gravity
            velocity.y += gravity * Time.deltaTime;

            controller.Move(velocity * Time.deltaTime);
        }
    }
}