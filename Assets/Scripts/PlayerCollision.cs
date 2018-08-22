using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour {
	public PlayerMovement movement;
	void OnCollisionEnter2D(Collision2D collisionInfo) {
		if(collisionInfo.collider.tag == "Ground")
		{
			Debug.Log("Collided with ground!");
			movement.isOnGround = true;
			movement.isJumping = false;
		}
	}

	void OnCollisionStay2D(Collision2D collisionInfo) {
	}

	void OnCollisionExit2D(Collision2D collisionInfo) {
		if(collisionInfo.collider.tag == "Ground")
		{
			Debug.Log("In the air!");
			movement.isOnGround = false;
		}
	}
}
