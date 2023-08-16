using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class go : MonoBehaviour
{
    public CharacterController controller;
    public float Speed = 12f;
    public Animator myAnimator;

    public float gravity = -9.8f;
    Vector3 velocity;

    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");
        Vector3 move = transform.right * x + transform.forward * z;

        controller.Move(move * Speed * Time.deltaTime);
        velocity.y += gravity * Time.deltaTime;
        controller.Move(velocity * Time.deltaTime);
        if (Input.GetKey(KeyCode.W))
            myAnimator.Play("Walk");
        else if (Input.GetKey(KeyCode.A))
            myAnimator.Play("Strafe L");
        else if (Input.GetKey(KeyCode.D))
            myAnimator.Play("Strafe R");
        else
            myAnimator.Play("Idle01");
    }
}