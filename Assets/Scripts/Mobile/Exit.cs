using UnityEngine;
using System.Collections;

public class Exit : MonoBehaviour {

	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown(KeyCode.Backspace)){
			Application.Quit();
		}
	}
}
