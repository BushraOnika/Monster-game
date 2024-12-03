using UnityEngine;

public class Owch : MonoBehaviour
{
    public GameObject text;
    public int angry;
    public Phone phone;
    public bool friendCalled;

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
        if (friendCalled) return;
        if (angry > 100)
        {
            phone.CallFriend();
            friendCalled = true;
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