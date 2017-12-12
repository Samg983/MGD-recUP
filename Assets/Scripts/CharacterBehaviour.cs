using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterBehaviour : MonoBehaviour {

	private Rigidbody2D rb2d;

	private Animator animator;

	[SerializeField]
	private float movementSpeed = 10;

	private bool facingRight;

	[SerializeField]
	private SpriteRenderer sprite;

	// Use this for initialization
	void Start () {
		facingRight = true;
		rb2d = GetComponent<Rigidbody2D>();
		animator = sprite.GetComponent<Animator>();
	
	}
	
	// Update is called once per frame
	void Update () {
		float horizontal = Input.GetAxis("Horizontal");
		HandleMovement(horizontal);
		Flip(horizontal);
	}

	private void HandleMovement(float horizontal){

		rb2d.velocity = new Vector2(horizontal * movementSpeed, rb2d.velocity.y);
		animator.SetFloat("speed", Mathf.Abs(horizontal));
	}

	private void Flip(float horizontal){

		if(horizontal > 0 && !facingRight || horizontal < 0 && facingRight){
			facingRight = !facingRight;

			Vector3 theScale = transform.localScale;

			theScale.x *= -1;

			transform.localScale = theScale;

			//sprite.transform.localScale = theScale;
		}
	}
}
