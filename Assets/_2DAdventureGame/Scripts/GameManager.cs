using UnityEngine;
using UnityEngine.SceneManagement;
public class GameManager : MonoBehaviour
{
public PlayerController1 player;
NewMonoBehaviourScript[] enemies;
public UIHandler uiHandler;
void Start()
{
enemies = FindObjectsByType<NewMonoBehaviourScript>(
FindObjectsSortMode.None);
}
void ReloadScene()
{
SceneManager.LoadScene(SceneManager.GetActiveScene().name);
}
void Update()
{
if (player.health <= 0)
{
uiHandler.DisplayLoseScreen();
Invoke(nameof(ReloadScene), 3f);
}
if (AllEnemiesFixed())
{
uiHandler.DisplayWinScreen();
Invoke(nameof(ReloadScene), 3f);
}
}
bool AllEnemiesFixed()
{
foreach (NewMonoBehaviourScript enemy in enemies)
{
if (enemy.isBroken) return false;
}
return true;
}
}