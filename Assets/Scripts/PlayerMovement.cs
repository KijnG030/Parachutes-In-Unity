using UnityEngine;
using UnityEngine.UIElements;

public class PlayerMovement : MonoBehaviour
{
	Rigidbody2D playerRigidbody;

	[SerializeField] private float playerThrust;
    private float horizontalInput;

    [SerializeField] private SpriteRenderer SpriteRenderer;

	private float xPosLastFrame;

	private void Start()
	{
        playerRigidbody = GetComponent<Rigidbody2D>();
	}

	private void Update()
	{
        horizontalInput = Input.GetAxisRaw("Horizontal");
        PlayerLookDirection();
	}

    private void FixedUpdate()
    {
		Movement();
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
        playerRigidbody.AddForce(Vector2.right * horizontalInput * playerThrust);
    }
}
