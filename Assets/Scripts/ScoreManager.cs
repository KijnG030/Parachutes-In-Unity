using JetBrains.Annotations;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    //public static ScoreManager instance;
    [SerializeField] private TextMeshProUGUI scoreText;
	[SerializeField] private TextMeshProUGUI highScoreText;
	[SerializeField] private TextMeshProUGUI livesText;

	public static int score = 0;
	public static int highScore = 0;
	public static int lives = 3;


	// roept de twee functies aan
	private void Update()
	{
        UpdateScore();
		SaveHighScore();
		UpdateLives();
		GameOver();
	}

	// Geeft de nieuwe text voor de score text zodat het geupdate kan worden
	private void UpdateScore()
	{
		scoreText.text = "Score: " + score;
	}

	private void SaveHighScore()
	{
		if (score > highScore)
		{
			highScore = score;
		}
		highScoreText.text = "High Score: " + highScore;
	}

	private void UpdateLives()
	{
		livesText.text = "Lives: " + lives;
	}

	// Als lives naar 0 gaat ga je game over en wordt de scene verandered naar het game over scherm
	private void GameOver()
	{
		if (lives == 0)
		{
			SceneManager.LoadScene("GameOver");
			lives = 3;
		}
	}
}
