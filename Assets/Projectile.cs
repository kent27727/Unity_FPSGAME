using UnityEngine;

public class Projectile : MonoBehaviour
{
    public float speed = 20f;
    public float lifetime;

    private void OnEnable()
    {
        lifetime = 10f;
    }

    private void Update()
    {
        lifetime -=Time.deltaTime;
        if (lifetime <= 0)
        {
            gameObject.SetActive(false);
        }
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }
}