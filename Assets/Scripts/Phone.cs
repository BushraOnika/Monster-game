using UnityEngine;

public class Phone : MonoBehaviour
{
    public GameObject friendPrefab;
    public Transform ghostHome;
    public void CallFriend()
    {
        Instantiate(friendPrefab, ghostHome.position, Quaternion.identity);
    }
}