using System.Collections;
using UnityEngine;

public abstract class PlayerAbility : ScriptableObject {

	public string abilityName = "AbilityName";
	public Sprite abilitySprite;
	public AudioClip abilitySound;
	public float abilityBaseCoolDown = 1f;

	public abstract void Initialize(GameObject obj);
	public abstract void TriggerAbility();
}
