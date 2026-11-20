
using UnityEngine;

public class Treasure : MonoBehaviour
{
    public GameManager gameManager;

    void OnTriggerEnter2D(Collider2D other)
    {
        PlayerController1 player =
            other.GetComponent<PlayerController1>();

        if (player != null)
        {
            gameManager.WinGame();
        }
    }
}
