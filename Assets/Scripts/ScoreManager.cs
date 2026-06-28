using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScoreManager : MonoBehaviour
{
    //public static ScoreManager instance;
    [SerializeField] private TextMeshProUGUI scoreText;
	[SerializeField] private TextMeshProUGUI highScoreText;
	[SerializeField] private TextMeshProUGUI livesText;

	public static int score = 0;
	public static int highScore = 0;
	public static int lives = 3;

    private void Start()
    {
        scoreText.text = "Points: " + score;
        highScoreText.text = "High Score: " + highScore;
        livesText.text = "Lives: " + lives;
    }

    private void OnEnable()
    {
        GameEvents.OnScoreAdded += AddScore;
        GameEvents.OnLivesChanged += ChangeLives;
    }

    private void OnDisable()
    {
        GameEvents.OnScoreAdded -= AddScore;
        GameEvents.OnLivesChanged -= ChangeLives;
    }

    private void AddScore(int amount)
    {
        score += amount;
        if (score > highScore)
        {
            highScore = score;
        }

        scoreText.text = "Points: " + score;
        highScoreText.text = "High Score: " + highScore;
    }

    private void ChangeLives(int amount)
    {
        lives += amount;

        livesText.text = "Lives: " + lives;
    }
}
