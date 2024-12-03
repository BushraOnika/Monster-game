using UnityEngine;

public class Damage : MonoBehaviour
{
    public int damgeValue = 1;
    
    private void OnCollisionEnter2D(Collision2D other)
    {
        var health = other.gameObject.GetComponent<Health>();
        if (health != null)
        {
            health.Value -= damgeValue;
        }
    }
}