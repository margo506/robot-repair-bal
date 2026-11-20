
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public PlayerController1 player;
    public UIHandler uiHandler;
    bool gameOver = false;

    void ReloadScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    void Update()
    {
        if (gameOver)
            return;

        if (player.health <= 0)
        {
            uiHandler.DisplayLoseScreen();
            gameOver = true;
            Invoke(nameof(ReloadScene), 3f);
        }
    }

    public void WinGame()
    {
        if (gameOver)
            return;

        uiHandler.DisplayWinScreen();
        gameOver = true;
        Invoke(nameof(ReloadScene), 3f);
    }
}
