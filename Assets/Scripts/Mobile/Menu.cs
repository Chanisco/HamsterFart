using UnityEngine;
using System.Collections;

public class Menu : MonoBehaviour {
	// Update is called once per frame
	private float chosenPosYTrue = -8.5f;
	private float chosenPosYFalse = -11f;
	private bool windowOpen = false;
	private bool done = true;
	public float ScreenSpeed = 0.3000001f;
	void Update () {
		if(Input.GetKeyDown(KeyCode.Menu) || Input .GetKeyDown(KeyCode.A)){
			done = false;
			if(!windowOpen && transform.position.y < chosenPosYTrue){
				windowOpen = true;
			}else if(windowOpen && transform.position.y > chosenPosYFalse){
				windowOpen = false;
			}
		}
		if(!done){
			GotoAndSet(windowOpen);
		}


	}

	void GotoAndSet(bool Complete){
		float yPos = transform.position.y;
		if(yPos < chosenPosYTrue && Complete){
			yPos += 0.1000001f;
			Global.MenuOn = true;
		}else if(yPos > chosenPosYTrue && Complete){
			done = true;
		}
		
		if(yPos > chosenPosYFalse && !Complete){
			yPos -= 0.1000001f;
			Global.MenuOn = false;

		}else if(yPos < chosenPosYFalse && !Complete){
			done = true;
			Debug.Log(windowOpen);
		}
		transform.position = new Vector3(0,yPos,0);
	}

	bool Difference(bool Boolean){
		if(!Boolean){
			Boolean = true;
		}else{
			Boolean = false;
		}
		return Boolean;

	}

}
