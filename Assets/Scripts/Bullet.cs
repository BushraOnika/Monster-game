using UnityEngine;

public class Bullet : MonoBehaviour
{
    public Rigidbody2D rb2D;
    public float speed = 10;
 
    public float damage = 1;
    private void Update()
    {
        rb2D.linearVelocity = new Vector2(speed, 0);
    }
    public void OnTriggerEnter2D(Collider2D other)
    {
        var health = other.gameObject.GetComponent<Health>();
        if (health != null)
        {
            health.Value -= damage;
        }
    }
}