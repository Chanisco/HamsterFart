using UnityEngine;
using System.Collections;

public class Swipe : MonoBehaviour {
	private float minDistantX = 1;
	private Vector3 startPos;
	private float j = 0;
	private bool turn = true;
	private float SwipeDistance;
	private float tempSwipeDist;
	private bool Direction;
	private float speed = 10;
	public float Posibilities = 6;

	void Start(){
		//Debug.Log();
		Posibilities = 360 / Posibilities;
	}
	void Update(){
		if(Global.MenuOn == false){
				Swiping();
		}
		if(turn){
			CameraTurn(SwipeDistance,Direction);
		}
		if(Input.GetKey(KeyCode.A)){
			turn = true;
		}
		Debug.Log(turn + "J = " + j);

	}

	 void Swiping(){
		if(Input.touchCount > 0){
			Touch touch = Input.touches[0];
			
			switch(touch.phase){
			case TouchPhase.Began:
				startPos = touch.position;
				break;
				
			case TouchPhase.Ended:
				Vector3 resultVector = (new Vector3(0, touch.position.x,0) - new Vector3(0,startPos.x,0));
				float SwipeDistanceX = resultVector.magnitude;
				
				if(SwipeDistanceX > minDistantX){
					float swipeValue = Mathf.Sign(touch.position.x- startPos.x);
					if(swipeValue > 0){
						Direction = false;
						turn = true;
						tempSwipeDist = -(Mathf.Round(SwipeDistanceX / 10) * 10) % Posibilities;
						SwipeDistance = -(Mathf.Round(SwipeDistanceX / 10) * 10) - tempSwipeDist;
					}else if(swipeValue < 0){
						Direction = true;
						turn = true;
						tempSwipeDist = (Mathf.Round(SwipeDistanceX / 10) * 10) % Posibilities;
						SwipeDistance = (Mathf.Round(SwipeDistanceX / 10) * 10) - tempSwipeDist;
					}
				}
				break;
				
			}
		}
	}

	void CameraTurn(float Distance,bool Side){
		if(j < Distance && Side){
			transform.Rotate(0,0,speed);
			j += speed;
		}
		else if(j >= Distance && Side){
			turn = false;
			j = 0;
		}
		if(j > Distance && !Side){
			transform.Rotate(0,0,-speed);
			j -= speed;
		}else if (j <= Distance && !Side){
			turn = false;
			j = 0;
		}

	}
}
