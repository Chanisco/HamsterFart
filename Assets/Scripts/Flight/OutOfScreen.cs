using UnityEngine;
using System.Collections;

public class OutOfScreen : MonoBehaviour {


	void Update () {
		CheckSides();
		if(Global.Death = false){
			FallinOutScreen();
		}

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
			Global.Death = true;
		}
	}


}
