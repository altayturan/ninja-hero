using UnityEngine;



public class PlayerMovement : MonoBehaviour
{

    [SerializeField] private Rigidbody rb;
    [SerializeField] private JoystickController joystick;
    [SerializeField] private PlayerData playerData;
    [SerializeField] private StateData stateData;


    public void SetPlayerVelocity()
    {
        var speed = playerData.Speed;

        if (stateData.CurrentState == States.PLAY)
        {
            rb.velocity = new Vector3(joystick.Horizontal * speed, 0, joystick.Vertical * speed);
        }
        else
        {
            SetPlayVelocityToZero();
        }
    }

    public void SetPlayVelocityToZero()
    {
        rb.velocity = Vector3.zero;
    }
}
