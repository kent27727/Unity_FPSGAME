using UnityEngine;

public class PlayerMovement : MonoBehaviour, IMovement
{
    public float moveSpeed = 5f;
    private CharacterController characterController;

    private void Start()
    {
        characterController = GetComponent<CharacterController>();
    }

    public void Move(float horizontalInput, float verticalInput,Animator anim)
    {
        Vector3 movement = transform.forward * verticalInput + transform.right * horizontalInput;
        movement.y = 0f;
        characterController.Move(movement * moveSpeed * Time.deltaTime);
        if ( movement.x!=0 &&movement.z!=0 )
        {
            anim.SetBool("Walking", true);
        }

        else if (movement.x == 0 && movement.z == 0)
        {
            anim.SetBool("Walking", false);
        }
    }
}