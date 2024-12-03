using System;
using UnityEngine;

public class Walk : MonoBehaviour
{
    public float keyinput;
    public Rigidbody2D rb2D;

    public void Awake()
    {
        Debug.Log("I am awake");
    }

    private void Reset()
    {
        rb2D = GetComponent<Rigidbody2D>();
    }

    private void OnEnable()
    {
        Debug.Log("hi");
    }

    private void Start()
    {
        Debug.Log("I am only going to say this once");
    }

    private void Update()
    {
        keyinput = Input.GetAxis("Horizontal");
        // transform.position += new Vector3(keyinput, 0, 0);
        rb2D.linearVelocity = new Vector3(keyinput, rb2D.linearVelocity.y, 0);
    }

    private void OnDisable()
    {
        Debug.Log("bye");
    }

    private void OnDestroy()
    {
        Debug.Log("I am dead");
    }
}