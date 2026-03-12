using UnityEngine;
using UnityEngine.UIElements;

public class PlayerMovement : MonoBehaviour
{
	Rigidbody2D p_Rigidbody;

	[SerializeField] private float p_thrust = 20f;

	[SerializeField] private SpriteRenderer SpriteRenderer;

	private float xPosLastFrame;

	private void Start()
	{
		p_Rigidbody = GetComponent<Rigidbody2D>();
	}

	private void FixedUpdate()
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
			p_Rigidbody.AddForce(transform.right * p_thrust * -1);
		}
		if (Input.GetKey(KeyCode.D))
		{
			p_Rigidbody.AddForce(transform.right * p_thrust);
		}
	}
}
