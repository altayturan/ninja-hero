using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private Rigidbody rb;
    [SerializeField] private DynamicJoystick joystick;
    private float speed;
    [SerializeField] private Animator animator;



    private void FixedUpdate()
    {
        speed = PlayerController.Instance.Speed;
        rb.velocity = new Vector3(joystick.Horizontal * speed, 0, joystick.Vertical * speed);
        if(rb.velocity != Vector3.zero) { animator.SetBool("isRunning", true); }
        else { animator.SetBool("isRunning", false); }
    }
}
