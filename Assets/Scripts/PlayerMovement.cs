using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {
	
	[HideInInspector]public bool isOnGround = false;
	public float movementSpeed = 1f;
	float updatedPositionX = 0f;
	public Rigidbody2D playerRigidbody;
	Vector2 updatedPosition;

	public JumpAbility jumpAbility;

	//
	void Start() {
		jumpAbility.Initialize(gameObject);
	}
	// Update is called once per frame
	void FixedUpdate () {

		updatedPositionX = Input.GetAxis("Horizontal") * movementSpeed * Time.deltaTime;

		updatedPosition.Set(updatedPositionX, 0f);
		//Debug.Log(updatedPosition);
		playerRigidbody.MovePosition(playerRigidbody.position + updatedPosition);

		if(isOnGround && Input.GetButton("Jump")){
			jumpAbility.TriggerAbility();
		}
	}
}
