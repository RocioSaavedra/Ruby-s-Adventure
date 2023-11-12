using UnityEngine;

/// <summary>
/// This class will apply continuous damage to the Player as long as it stay inside the trigger on the same object
/// </summary>
public class DamageZone2 : MonoBehaviour 
{
    void OnTriggerStay2D(Collider2D other)
    {
        RubyController2 controller = other.GetComponent<RubyController2>();

        if (controller != null)
        {
            //the controller will take care of ignoring the damage during the invincibility time.
            controller.ChangeHealth(-1);
        }
    }
}
