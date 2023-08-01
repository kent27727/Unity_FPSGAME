using UnityEngine;

public interface IMovement
{
    void Move(float horizontalInput, float verticalInput,Animator anim);
}