using UnityEngine;

public class Gun : MonoBehaviour
{
    public Bullet bulletPrefab;

    public void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Instantiate(bulletPrefab, transform.position, Quaternion.identity);
        }
    }
}