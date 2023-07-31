using UnityEngine;

public class FPSController : MonoBehaviour
{
    private IMovement movementController;
    private ILook lookController;

    private void Awake()
    {
        movementController = GetComponent<PlayerMovement>();
        lookController = GetComponent<PlayerLook>();
    }

    private void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");
        movementController.Move(horizontalInput, verticalInput);

        float mouseX = Input.GetAxis("Mouse X");
        float mouseY = Input.GetAxis("Mouse Y");
        lookController.Look(mouseX, mouseY);
    }
}