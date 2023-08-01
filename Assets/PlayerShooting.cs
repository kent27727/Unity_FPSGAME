using UnityEngine;

public class PlayerShooting : MonoBehaviour, IFire
{
    public void Fire(Rigidbody projectileRb, Transform firePoint, float speed)
    {
        Camera playerCamera = GetComponentInChildren<Camera>();

        Vector3 screenCenter = new Vector3(Screen.width / 2f, Screen.height / 2f, 0f);
        Ray ray = playerCamera.ScreenPointToRay(screenCenter);

        if (Physics.Raycast(ray, out RaycastHit hit))
        {

            if (projectileRb != null)
            {
                projectileRb.velocity = (hit.point - transform.position).normalized * speed;
            }
        }
    }
}