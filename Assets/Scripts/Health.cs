using UnityEngine;

public class Health : MonoBehaviour
{
    public float value = 5;
    
    private void Update()
    {
        if (value <= 0)
        {
            gameObject.SetActive(false);
        }
    }
}