using UnityEngine;

public class GunController : MonoBehaviour
{
    public GameObject projectilePrefab;
    public Transform firePoint;
    public float fireRate = 0.5f;

    private float nextFireTime;

    void FixedUpdate()
    {
        if (Input.GetButtonDown("Fire1") && Time.time >= nextFireTime)
        {
            Shoot();
            nextFireTime = Time.deltaTime + fireRate;
        }
    }

    void Shoot()
    {

        // Instantiate the projectile at the firePoint's position and rotatio0
        Instantiate(projectilePrefab, firePoint.position, firePoint.rotation);
    }
}