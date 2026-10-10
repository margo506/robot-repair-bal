using UnityEngine;
public class HealthCollectible : MonoBehaviour
{
void OnTriggerEnter2D(Collider2D other)
{
PlayerController1 controller =
other.GetComponent<PlayerController1>();
if (controller != null
&& controller.health < controller.maxHealth)
{
controller.ChangeHealth(1);
Destroy(gameObject);
}
}
}