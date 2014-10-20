using UnityEngine;
using System.Collections;

public class ForceUp : MonoBehaviour {
	void Update(){
		if(Global.ReadyToStart == true){
			Forcing();
		}

	}
	void Forcing(){
		if(Global.Force > 0){
			gravity.pressure = 0;
			if(transform.position.y < BgGoingDown.top + 1){
				transform.Translate(0,1f,0);
			}
			Global.Force -= 1;

		}
	}

}
