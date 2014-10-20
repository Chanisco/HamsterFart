using UnityEngine;
using System.Collections;

public class gravity : MonoBehaviour {

	public static float pressure = 0;
	public float pointZero = 0;

	void Update(){
		gravityDown();
	}

	void gravityDown () {
		if(Global.ReadyToStart && Global.Force < 1){
			if(pointZero != 0){
				pressure = -0.02f;
				pointZero -= 1;
			}else if(pressure != 0 & pointZero == 0){
				pressure -= 0.01f;
			}
		}
		if(Global.Force > 1){
			pointZero = 20;
		}
		transform.Translate(0,pressure,0);
	}
}
