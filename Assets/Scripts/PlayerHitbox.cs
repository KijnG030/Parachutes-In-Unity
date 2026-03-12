using UnityEngine;


//Handles all game objects that the player touches

public class PlayerHitbox : MonoBehaviour 
{
	[SerializeField] private int scorePoints = 1;
	private void OnTriggerEnter2D(Collider2D other)
	{
        if (other.gameObject.CompareTag("Lady"))
        {
            Destroy(other.gameObject);
			ScoreManager.score += scorePoints;
		}

		if (other.gameObject.CompareTag("Pow1"))
		{
			Destroy(other.gameObject);
			ScoreManager.lives += 1;
		}

		if (other.gameObject.CompareTag("Pow2"))
		{
			Destroy(other.gameObject);
			ScoreManager.score += 5;
		}
	}
}
