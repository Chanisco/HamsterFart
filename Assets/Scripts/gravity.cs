using UnityEngine;
using System.Collections;

public class gravity : MonoBehaviour {

	public static float pressure = 0;
	public float pointZero = 0;
	private float minorSetback = 0;

	void Update(){
		gravityDown();
	}

	void gravityDown () {
		if(Global.ReadyToStart && Global.Force < 1){
			if(pointZero != 0){
				if(minorSetback != 0){
					pressure = 0.1f;
					minorSetback -= 1;
				}else{
					pressure = -0.05f;
					pointZero -= 1;
				}
			}else if(pressure != 0 & pointZero == 0){
				pressure -= 0.01f;
			}
		}
		if(Global.Force > 1){
			pointZero = 20;
			minorSetback = 10;
		}
		//if(this.transform.position.y < BgGoingDown.top + 2){
			transform.Translate(0,pressure,0);
	//	}
	}
}
