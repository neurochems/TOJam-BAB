using UnityEngine;
using System.Collections;

public class CharacterController : MonoBehaviour {

	[SerializeField] private float maxSpeed = 10f;                    // The fastest the player can travel in the x axis.
	
	private Animator anim;            // Reference to the player's animator component.
	
	private bool facingRight = true;  // For determining which way the player is currently facing.

	public bool staff, cube, pyramid, crystal, scroll, allCollect, titleDone;

	private void Awake()
	{
		// Setting up references.
		anim = GetComponent<Animator>();
	}
	
	
	private void FixedUpdate()
	{
		float move = Input.GetAxis ("Horizontal");
		
		anim.SetFloat ("Speed", Mathf.Abs (move));

		GetComponent<Rigidbody2D>().velocity = new Vector2 (move * maxSpeed, GetComponent<Rigidbody2D>().velocity.y);
			
		if (move > 0 && !facingRight)
			// ... flip the player.
			Flip();
		// Otherwise if the input is moving the player left and the player is facing right...
		else if (move < 0 && facingRight)
			// ... flip the player.
			Flip();

		if (staff && cube && pyramid && crystal && scroll)		//all items collected
			allCollect = true;

	}

	
	private void Flip()
	{
		// Switch the way the player is labelled as facing.
		facingRight = !facingRight;
		
		// Multiply the player's x local scale by -1.
		Vector3 theScale = transform.localScale;
		theScale.x *= -1;
		transform.localScale = theScale;
	}
}

