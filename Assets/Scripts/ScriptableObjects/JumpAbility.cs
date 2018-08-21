using UnityEngine;

[CreateAssetMenu (menuName= "Abilities/JumpAbility")]
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
		objectRigidbody.AddForce(new Vector2(0, jumpForce), ForceMode2D.Impulse);
		//objectRigidbody.MovePosition(objectRigidbody.position + (new Vector2(jumpForce, 0)) * Time.deltaTime);
		
		// Downward force
		if(objectRigidbody.transform.position.y < -5){
			objectRigidbody.gravityScale = fallForceMax;
		} else if(objectRigidbody.transform.position.y < -6 && !Input.GetButton ("Jump")) {
			objectRigidbody.gravityScale = fallForceMin;
		}
	}
}
