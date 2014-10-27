using UnityEngine;
using System.Collections;

public class Btn : MonoBehaviour {
	private bool Chosen;
	private Vector2 Pos;

	void Update(){
		if(Input.touchCount > 0){
			PressedandReleased();
		}
	}

	void PressedandReleased(){
		Touch touch = Input.touches[0];
		switch(touch.phase){
		case TouchPhase.Began:
				Pos = touch.position;
				Chosen = true;
				break;

		case TouchPhase.Moved:
				Chosen = false;
			break;

		case TouchPhase.Ended:
				if(Chosen == true){
					Application.LoadLevel("LiftOff");
				}
			break;
		}
	}
	void OnBecameVisible(){
		enabled = true;
	}
	void OnBecameInvisible(){
		Chosen = false;
		enabled = false;
	}

}
