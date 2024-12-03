using UnityEngine;

public class Walk : MonoBehaviour
{
    public float keyinput;
    public Rigidbody2D rb2D;
    public Animator animator;

    private void Reset()
    {
        rb2D = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }

    private void Update()
    {
        keyinput = Input.GetAxis("Horizontal");

        if (0 < keyinput)
        {
            transform.localScale = new Vector3(1, 1, 1);
            animator.Play("walk");
        }
        else if (keyinput < 0)
        {
            transform.localScale = new Vector3(-1, 1, 1);
            animator.Play("walk");
        }
        else
        {
            animator.Play("idle");
        }

        rb2D.linearVelocity = new Vector3(keyinput, rb2D.linearVelocity.y, 0);
    }
}