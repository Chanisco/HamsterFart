using UnityEngine;
using System.Collections;

public class ToMiddleScreen : MonoBehaviour {
	private bool CountDownDone;
	void Start(){
		Global.Death = false;
		if(Global.ReadyToStart == false){
			Invoke("LiftOff",3);
		}
	}

	void LiftOff(){
	
		Global.Force = 5;
		Global.ReadyToStart = true;
	}


	
}
