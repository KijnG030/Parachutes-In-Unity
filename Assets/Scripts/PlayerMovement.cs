using UnityEngine;
using UnityEngine.UIElements;

public class PlayerMovement : MonoBehaviour
{
	Rigidbody2D playerRigidbody;

	[SerializeField] private float playerThrust = 20f;

	[SerializeField] private SpriteRenderer SpriteRenderer;

	private float xPosLastFrame;

	private void Start()
	{
        playerRigidbody = GetComponent<Rigidbody2D>();
	}

	private void Update()
	{
		Movement();
		PlayerLookDirection();
	}

	private void PlayerLookDirection()
	{
		if (transform.position.x > xPosLastFrame)
		{
			SpriteRenderer.flipX = false;
		}
		else if (transform.position.x < xPosLastFrame)
		{
			SpriteRenderer.flipX = true;
		}

		xPosLastFrame = transform.position.x;
	}

	private void Movement()
	{
		// gebruikt Rigidbody om karakter te laten bewegen met A naar links en D naar rechts
		if (Input.GetKey(KeyCode.A))
		{
			playerRigidbody.AddForce(transform.right * playerThrust * -1);
		}
		if (Input.GetKey(KeyCode.D))
		{
			playerRigidbody.AddForce(transform.right * playerThrust);
		}
	}
}
