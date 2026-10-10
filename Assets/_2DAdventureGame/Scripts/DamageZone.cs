using UnityEngine;
public class DamageZone : MonoBehaviour
{
void OnTriggerStay2D(Collider2D other)
{
PlayerController1 controller =
other.GetComponent<PlayerController1>();
if (controller != null)
{
controller.ChangeHealth(-1);
}
}
}