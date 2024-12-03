using System;
using UnityEngine;

public class Owch : MonoBehaviour
{
    public GameObject text;
    public int angry;

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.GetComponent<Walk>() != null)
        {
            text.SetActive(true);
            Debug.Log(other.gameObject.name);
        }
    }

    private void OnCollisionStay2D(Collision2D other)
    {
        if (other.gameObject.GetComponent<Walk>() != null)
        {
            angry++;
            Debug.Log("Angryy!!");
        }
    }

    private void Update()
    {
        if (angry > 100)
        {
            Debug.Log("You are dead!");
        }
    }


    public void OnCollisionExit2D(Collision2D other)
    {
        if (other.gameObject.GetComponent<Walk>() != null)
        {
            text.SetActive(false);
        }
    }
}