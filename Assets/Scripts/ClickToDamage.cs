using UnityEngine;

public class ClickToDamage : MonoBehaviour
{
    public int damage = 1;
    public Camera mainCamera;

    public void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = mainCamera.ScreenPointToRay(Input.mousePosition);
            Debug.DrawRay(ray.origin, ray.direction * 100, Color.yellow, 2);
            var raycastHit2D = Physics2D.Raycast(ray.origin, ray.direction, 100);
            if (raycastHit2D.collider != null)
            {
                var health = raycastHit2D.collider.gameObject.GetComponent<Health>();
                if (health != null)
                {
                    health.Value -= damage;
                }
            }
        }
    }
}