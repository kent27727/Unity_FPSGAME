using UnityEngine;

public interface IFire
{
    void Fire(Rigidbody projectileRb, Transform firePoint,float speed);
}