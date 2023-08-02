

using UnityEngine;

public class PlayerInput : IInput
{

    readonly string horizontal = "Horizontal";

    readonly string vertical = "Vertical";




    public float Horizontal => Input.GetAxisRaw(horizontal);

    public float Vertical => Input.GetAxisRaw(vertical);

    public bool IsJumping=> Input.GetButton("Jump");
    public bool IsCrouching=> Input.GetKey(KeyCode.LeftShift);
}
