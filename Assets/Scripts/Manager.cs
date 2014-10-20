using UnityEngine;
using System.Collections;

public class Manager : MonoBehaviour {
	// Update is called once per frame

	void Update () {
		if(GameObject.Find("Hamster").activeInHierarchy){
			this.enabled = false;
		}
	}
}
