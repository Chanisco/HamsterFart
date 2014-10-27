using UnityEngine;
using System.Collections;

public class MoveHamster : MonoBehaviour {
	void Update(){
		if(Global.ReadyToStart){
			Move ();
		}
	}

	void Move(){
		if(Input.GetKey(KeyCode.D)){
			transform.Translate(new Vector3(0.1f,0,0));
		}
		if(Input.GetKey(KeyCode.A)){
			transform.Translate(new Vector3(-0.1f,0,0));
		}
		if(Input.GetKey(KeyCode.W)){
			transform.Translate(new Vector3(0,1,0));
		}
		if(Input.GetKey(KeyCode.S)){
			transform.Translate(new Vector3(0,-1,0));
		}
		if(Input.GetKey(KeyCode.Space)){
			rigidbody2D.gravityScale = 0;
		}
		transform.Translate(Input.acceleration.x * 2,0,0);
	}

}
