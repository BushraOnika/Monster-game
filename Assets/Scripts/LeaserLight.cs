using UnityEngine;

public class LeaserLight : MonoBehaviour
{
    public float damage = 1;

    public void OnTriggerEnter2D(Collider2D other)
    {
        var health = other.gameObject.GetComponent<Health>();
        if (health != null)
        {
            health.value -= damage;
        }
    }
}