using UnityEngine;
using System.Collections;

public class BgGoingDown : MonoBehaviour {
	public GameObject Player,foreGround,points;
	public static float top = 3f;
	public static float middle = 0f;
	public static float bottom = -4;

	void Update () {
		if(Global.Force > 0){
			if(Player.transform.position.y >= top ){
				foreGround.transform.Translate(0,-0.05f,0);
				points.transform.Translate(0,-0.5f,0);
			}
			if(Player.transform.position.y >= middle && Player.transform.position.y <= top  ){
				foreGround.transform.Translate(0,-0.02f,0);
				points.transform.Translate(0,-0.2f,0);
			}
			if(Player.transform.position.y >= bottom && Player.transform.position.y <= middle  ){
				foreGround.transform.Translate(0,-0.01f,0);
				points.transform.Translate(0,-0.1f,0);
			}
		}
		if(Player.transform.position.y < top && Player.transform.position.y > middle){
			if(gravity.pressure < 0.001){
				foreGround.transform.Translate(0,0.01f,0);
			}
		}
		if(Player.transform.position.y > top ){
			if(gravity.pressure < 0.001){
				foreGround.transform.Translate(0,0.01f,0);
				points.transform.Translate(0,0.01f,0);
			}
		}
	}
}
