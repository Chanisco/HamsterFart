﻿using UnityEngine;
using System.Collections;

public class Onhit : MonoBehaviour {
	public bool Outfield;
	void OnTriggerEnter2D(Collider2D other){
		if(Outfield == true){
			if(other.tag == Tags.Point){
				Destroy(other.gameObject);
			}
		}else{
			if(other.tag == Tags.Point){
				if(Global.Force < 40){
					Global.Force += 5;
				}
				Destroy(other.gameObject);
			}
		}
	}


}
