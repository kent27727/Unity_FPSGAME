using UnityEngine;

public class PlayerLook : MonoBehaviour, ILook
{
    public float mouseSensitivity = 2f;
    private Camera playerCamera;
    private float verticalRotation = 0f;

    private void Start()
    {
        playerCamera = GetComponentInChildren<Camera>();
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    public void Look(float mouseX, float mouseY)
    {
        float rotationX = mouseX * mouseSensitivity;
        verticalRotation -= mouseY * mouseSensitivity;
        verticalRotation = Mathf.Clamp(verticalRotation, -90f, 90f);

        transform.Rotate(Vector3.up * rotationX);
        playerCamera.transform.localRotation = Quaternion.Euler(verticalRotation, 0f, 0f);
    }
}