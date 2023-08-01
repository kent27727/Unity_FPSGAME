using UnityEngine;

public class FPSController : MonoBehaviour
{
    private IMovement movementController;
   [SerializeField] private GameObject muzzleObject;
    private ILook lookController;
    private IFire fireController;
    private Animator anim;
    private Rigidbody projectileRb;

    private void Awake()
    {
        movementController = GetComponent<PlayerMovement>();
        lookController = GetComponent<PlayerLook>();
        fireController = GetComponent<PlayerShooting>();
        anim = GetComponent<Animator>();
        projectileRb = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");
        movementController.Move(horizontalInput, verticalInput,anim);

        float mouseX = Input.GetAxis("Mouse X");
        float mouseY = Input.GetAxis("Mouse Y");
        lookController.Look(mouseX, mouseY);

        if (Input.GetButton("Fire1"))
        {
            ObjectPooler.instance.SpawnFromPool("Bullet", new Vector3(muzzleObject.transform.position.x, muzzleObject.transform.position.y, muzzleObject.transform.position.z), muzzleObject.transform.rotation);
            fireController.Fire(projectileRb,muzzleObject.transform,20);
        }
    }
}