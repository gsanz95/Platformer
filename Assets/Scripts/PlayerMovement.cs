using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {
	
	[HideInInspector]public bool isOnGround = false;
	[HideInInspector]public bool isJumping = false;
	public float movementSpeed = 1f;
	public float maxJumpHeight = 10f;
	public float fallGravity = 2.5f;
	float deltaPositionX = 0f;
	float deltaPositionY = 1f;
	public Rigidbody2D playerRigidbody;
	Vector2 deltaPosition;

	//public JumpAbility jumpAbility;

	//
	void Start() {
		//jumpAbility.Initialize(gameObject);
	}
	// Update is called once per frame
	void FixedUpdate () {

		updatedHorizontal();

		updateVertical();

		deltaPosition.Set(deltaPositionX, deltaPositionY);

		//Debug.Log(updatedPosition);
		playerRigidbody.transform.position = (playerRigidbody.position + deltaPosition);
	}

	void updatedHorizontal() {
		deltaPositionX = Input.GetAxis("Horizontal") * movementSpeed;
		deltaPositionX = Mathf.MoveTowards(0f, deltaPositionX, movementSpeed);
		deltaPositionX *= Time.deltaTime;
	}

	void updateVertical() {
		//Debug.Log(deltaPositionY);
		if(isOnGround) {
			playerRigidbody.gravityScale = 1f;
			deltaPositionY = 0f;

			if(Input.GetButton("Jump")){
				//jumpAbility.TriggerAbility();
				deltaPositionY = maxJumpHeight;
				isJumping = true;
			}
		} else if(isJumping){
			deltaPositionY = maxJumpHeight;
			playerRigidbody.gravityScale = fallGravity;
		}

		deltaPositionY *= Time.deltaTime;

		//deltaPositionY = Mathf.MoveTowards(0f, deltaPositionY, fallSpeed);
	}
}
