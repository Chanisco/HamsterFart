using UnityEngine;
using System.Collections;

public class flagAwake : MonoBehaviour {

	private GameObject flagPiece;
	private Vector3 flagPos;
	private bool Complete = false;
	public float volumeSFX;
	public AudioClip effect;

	
	void Update(){
		if(Global.Death == true){
			if(!Complete){
				TextMesh flagText = gameObject.GetComponentInChildren<TextMesh>();
				flagText.fontSize = 25;
				flagText.text = "Score";
				Complete = true;
			}else if(Complete){
				GotoAndSet(gameObject,0);
			}
		}



	}
	public void GotoAndSet(GameObject flag,int Position){
		flagPos = new Vector3(0,Position,0);
		float yPos = flag.transform.position.y;
		if(yPos > flagPos.y){
			yPos -= 0.1000001f;
		}else{
			VlagCollide();	
			TextMesh flagText = gameObject.GetComponentInChildren<TextMesh>();
			flagText.text = "Man i'm cool";
			Debug.Log("Its here");

		}
		flag.transform.position = new Vector3(0,yPos,0);

	}

	void VlagCollide(){
		//AudioSource.PlayClipAtPoint(effect,new Vector3(0,0,0),volumeSFX);
		
	}
}

