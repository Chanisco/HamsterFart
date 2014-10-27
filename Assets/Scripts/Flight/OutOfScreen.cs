using UnityEngine;
using System.Collections;

public class OutOfScreen : MonoBehaviour {


	void Update () {
		CheckSides();
		FallinOutScreen();

	}

	void CheckSides () {
		if(transform.position.x < -5){
			transform.Translate(9,0,0);
		}
		if(transform.position.x > 5){
			transform.Translate(-9,0,0);
		}
	
	}
	void FallinOutScreen(){
		if(transform.position.y < -6){
			Destroy(gameObject);
		}
	}
}
