using System;
using UnityEngine;

public class Walk : MonoBehaviour
{
    public float keyinput;
    public Rigidbody2D rb2D;
    public Animator animator;
    public bool isGrounded;
    private string Ground_tag = "Ground";

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

    private void FixedUpdate()
    {
        PlayerJump();
    }

    void PlayerJump()
    {
        if (Input.GetButtonDown("Jump") && isGrounded)
        {
            isGrounded = false;
            rb2D.AddForce(new Vector2(0f,10f),ForceMode2D.Impulse);
            
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag(Ground_tag))
        {
            isGrounded = true;
        }
    }
}