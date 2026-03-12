using System.Runtime.CompilerServices;
using Unity.VisualScripting;
using UnityEngine;


// If game object lady enters the death plane, the player will lose 1 life
public class DeathPlane : MonoBehaviour
{
	private void OnTriggerEnter2D(Collider2D other)
	{
		if (other.gameObject.CompareTag("Lady"))
		{
			Destroy(other.gameObject);
			ScoreManager.lives -= 1;
		}
	}

}
