using UnityEngine;

public class Health : MonoBehaviour
{
    [SerializeField] private float value = 5;
    
    public SpriteRenderer spriteRenderer;
    public Color whiteColor = Color.white;
    public Color flashColor = Color.red;
    
    public float flashDuration = .1f;
    public bool flash;
    
    public float flashTime = 0;

    public float Value
    {
        get => value;
        set
        {
            this.value = value;
            flash = true;
            spriteRenderer.color = flashColor;
        }
    }

    private void Update()
    {
        if (Value <= 0)
        {
            gameObject.SetActive(false);
        }

        if (flash)
        {
            flashTime += Time.deltaTime;
            if(flashTime >= flashDuration)
            {
                flashTime = 0;
                flash = false;
                spriteRenderer.color = whiteColor;
            }
        }
        
    }
}