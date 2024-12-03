using UnityEngine;

public class Follow : MonoBehaviour
{
    public Transform target;
    public float moveSpeed = 1f;
    public Rigidbody2D rb2D;
    
    private void Reset()
    {
        rb2D = GetComponent<Rigidbody2D>();
    }
    
    private void Update()
    {
        var direction = target.position - transform.position;
        rb2D.linearVelocity = direction.normalized * moveSpeed;
    }
    
}