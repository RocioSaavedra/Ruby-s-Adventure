using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Anna Kahn changes / Rocio Saavedra helped make it work
public class SpeedCollectible : MonoBehaviour
{
    public AudioClip collectedClip;
    
    void OnTriggerEnter2D(Collider2D other)
    {
        RubyController controller = other.GetComponent<RubyController>();

       if (controller != null)
        {
            if (controller.speed == 3.0f)
            {
                
                Destroy(gameObject);

                controller.PlaySound(collectedClip);
            }
        }
    }

  
}
