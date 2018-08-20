using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {
	
	bool isOnGround = true;
	public float movementSpeed = 1f;

	JumpAbility jumpAbility;

	//
	void Start() {
		jumpAbility.Initialize(gameObject);
	}
	// Update is called once per frame
	void Update () {
		if(isOnGround){
			jumpAbility.TriggerAbility();
		}
	}
}
