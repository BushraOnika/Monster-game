using UnityEngine;

public class Bullet : MonoBehaviour
{
    public Rigidbody2D rb2D;
    public float speed = 10;

    private void Update()
    {
        rb2D.linearVelocity = new Vector2(speed, 0);
    }
}