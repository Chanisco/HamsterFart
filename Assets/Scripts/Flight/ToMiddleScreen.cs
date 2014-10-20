using UnityEngine;
using System.Collections;

public class ToMiddleScreen : MonoBehaviour {

	void Update () {
		if(Global.ReadyToStart == false){
			LiftOff();
		}
	}

	void LiftOff(){
		Global.Force = 5;
		Global.ReadyToStart = true;
	}


	
}
