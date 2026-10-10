using UnityEngine;

public class HealthCollectible : MonoBehaviour
{
    public int healthAmount = 1;

    void OnTriggerEnter2D(Collider2D other)
    {
        PlayerController1 controller =
            other.GetComponent<PlayerController1>();

        if (controller != null
            && controller.health < controller.maxHealth)
        {
            controller.ChangeHealth(healthAmount);
            Destroy(gameObject);
        }
    }
}