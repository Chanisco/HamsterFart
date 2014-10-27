using UnityEngine;
using System.Collections;

public class CharacterAnimation : MonoBehaviour {


	public Animator animator;
	public float animationCount;
	public bool IdleBool;
	// Use this for initialization
	void Start () {
		animator = GetComponent<Animator>();
	}
	void Update(){
		if(animationCount > 0){
			animationCount -= 1;
		}
		animator.SetBool("Idle",IdleBool);
	}

	public void Idle(){
		TurningAnimationsOff();
		IdleBool = true;
	}

	public void Eat(){
		animator.SetFloat("Eat",animationCount);


	}

	void TurningAnimationsOff(){
		IdleBool = false;

	}
}
