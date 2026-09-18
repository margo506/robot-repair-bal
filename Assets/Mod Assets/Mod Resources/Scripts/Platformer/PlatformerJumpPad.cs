using UnityEngine;

public class PlatformerJumpPad : MonoBehaviour
{
    public float verticalVelocity;

    void OnTriggerEnter2D(Collider2D other)
    {
        var rb = other.attachedRigidbody;
        if (rb == null) return;

        var player = rb.GetComponent<Platformer.Mechanics.PlayerController>();
        if (player == null) return;

        player.Bounce(verticalVelocity);
    }
}
