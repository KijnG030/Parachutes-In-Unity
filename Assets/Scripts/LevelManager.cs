using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LevelManager : MonoBehaviour
{
    private bool gameOverLoaded = false;

    private void Update()
    {
        if (!gameOverLoaded && ScoreManager.lives <= 0)
        {
            gameOverLoaded = true;
            ScoreManager.score = 0;
            ScoreManager.lives = 3;

            SceneManager.LoadScene("GameOver");
        }
    }
}
