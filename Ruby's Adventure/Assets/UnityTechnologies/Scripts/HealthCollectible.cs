using UnityEngine;

/// <summary>
/// Will handle giving health to the character when they enter the trigger.
/// </summary>
public class HealthCollectible2 : MonoBehaviour 
{
    public AudioClip collectedClip;

    void OnTriggerEnter2D(Collider2D other)
    {
        RubyController2 controller = other.GetComponent<RubyController2>();

        if (controller != null)
        {
            if (controller.health < controller.maxHealth)
            {
                controller.ChangeHealth(1);
                Destroy(gameObject);

                controller.PlaySound(collectedClip);
            }
        }
    }
}
