using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private Rigidbody rb;
    [SerializeField] private DynamicJoystick joystick;
    private float speed;



    private void FixedUpdate()
    {
        speed = PlayerController.Instance.GetSpeed();
        rb.velocity = new Vector3(joystick.Horizontal * speed, 0, joystick.Vertical * speed);
    }
}
