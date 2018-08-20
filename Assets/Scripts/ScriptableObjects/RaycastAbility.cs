using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu (menuName= "Abilities/RaycastAbility")]
public class RaycastAbility : PlayerAbility {

	public int damage = 1;
	public float range = 50f;
	public float hitForce = 100f;
	public Color hitColor = Color.white;

	private RaycastShootTriggerable rcShoot;

	public override void Initialize(GameObject obj){
		rcShoot = obj.GetComponent<RaycastShootTriggerable> ();
		rcShoot.Initialize ();

	}

	public override void TriggerAbility() {
		rcShoot.Fire ();
	}
}
