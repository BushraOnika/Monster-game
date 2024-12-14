using UnityEngine;

public class Gun : MonoBehaviour
{
    public Bullet bulletPrefab;
    public bool isRight;
    public Transform playerTransform;
    
    public void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            var difference= playerTransform.position - transform.position;
            Debug.Log(difference.x);
            Bullet bullet = Instantiate(bulletPrefab, transform.position, Quaternion.identity);
            if (difference.x <0)
            {
                bullet.speed = 1.5f;
               // isRight = false;
            }
            else
            {
                bullet.speed = -1.5f;
                // isRight = true;
            }
        }
    }
}