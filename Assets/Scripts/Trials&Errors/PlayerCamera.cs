using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCamera : MonoBehaviour {

	public Transform targetTransform;

	public float lerpSpeed;
	public Vector3 offset;

	Vector3 desiredCameraPosition;
	Vector3 trueCameraPosition;
	Vector3 targetSpawnPosition;
	public float cameraMinXPosition;
	public float cameraMaxXPosition;
	public float cameraMinYPosition;
	public float cameraMaxYPosition;

	bool isLookingAhead = true;

	void Start() {
		targetSpawnPosition = targetTransform.position;
	}

	// Update is called once per frame
	void FixedUpdate () {
		desiredCameraPosition = targetTransform.position + offset;
		
		/*if(Input.GetAxis("Horizontal") > 0 && isLookingAhead == false){
			isLookingAhead = true;
			desiredCameraPosition.x += 12;
		} else if(Input.GetAxis("Horizontal") < 0 && isLookingAhead == true) {
			isLookingAhead = false;
			desiredCameraPosition.x -= 12;
		}*/

		if(desiredCameraPosition.x < cameraMinXPosition) {
			desiredCameraPosition.x = cameraMinXPosition;
		} else if(desiredCameraPosition.x > cameraMaxXPosition) {
			desiredCameraPosition.x = cameraMaxXPosition;
		}

		if(desiredCameraPosition.y < cameraMinYPosition) {
			desiredCameraPosition.y = cameraMinYPosition;
		} else if(desiredCameraPosition.y > cameraMaxYPosition) {
			desiredCameraPosition.y = cameraMaxYPosition;
		}
		
		trueCameraPosition = Vector3.Lerp(gameObject.transform.position, desiredCameraPosition, .125f);
		gameObject.transform.position = trueCameraPosition;


	}
}
