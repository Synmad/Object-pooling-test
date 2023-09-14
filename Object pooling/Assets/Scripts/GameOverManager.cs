using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverManager : MonoBehaviour
{
    private void Awake() { PlayerController.onPlayerDie += GameOver; }

    void GameOver() { SceneManager.LoadScene("SampleScene"); }
}
