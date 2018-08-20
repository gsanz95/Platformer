using System.Collections;
using UnityEngine;

// A behaviour that is attached to a playable
public class JumpAbility : PlayerAbility
{
	public float jumpForce = 2f;
	public float fallForceMax = 2.5f;
	public float fallForceMin = 2f;
	private Rigidbody2D objectRigidbody;

	public override void Initialize(GameObject obj){
		objectRigidbody = obj.GetComponent<Rigidbody2D> ();
	}

	public override void TriggerAbility() {
		Debug.Log("Jumping!");

		// Upward force
		if(Input.GetButtonDown("Jump")) {
			objectRigidbody.velocity = Vector2.up * jumpForce;
		}
		
		// Downward force
		if(objectRigidbody.velocity.y < 0){
			objectRigidbody.velocity += Vector2.up * Physics2D.gravity.y * (fallForceMax - 1) * Time.deltaTime;
		} else if(objectRigidbody.velocity.y > 0 && !Input.GetButton ("Jump")) {
			objectRigidbody.velocity += Vector2.up * Physics2D.gravity.y * (fallForceMin - 1) * Time.deltaTime;
		}
	}
}
