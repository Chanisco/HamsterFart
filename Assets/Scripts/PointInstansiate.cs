using UnityEngine;
using System.Collections;

public class PointInstansiate : MonoBehaviour {

	public GameObject[] pointObject;
	private GameObject pointFirst;
	private  Transform  pointArr;
	private int i;
	private int j;

	public int AllPointPaces = 3;

	void Start () {
		if(pointArr == null){
			pointArr = GameObject.Find("Points").transform;
		}
	/*	GameObject pointFirst = Instantiate(pointObject[0],new Vector3(0,transform.position.y,0),Quaternion.identity) as GameObject;
		pointFirst.transform.parent = GameObject.Find("Points").transform;*/
	
		for(j = 0;j < 100;j++){
			i = Random.Range(0,AllPointPaces);
			GameObject pointFirst = Instantiate(pointObject[i],new Vector3(0,j * 8,0),Quaternion.identity) as GameObject;
			pointFirst.gameObject.transform.parent = pointArr;
			j++;
		}
	}

	void FixedUpdate () {
		/*if(transform.position.y  / 3 < i){

			GameObject pointFirst = Instantiate(pointObject[j],new Vector3(0,transform.position.y - (20 * i),0),Quaternion.identity) as GameObject;
			pointFirst.gameObject.transform.parent = pointArr;
			i--;
		}*/

	}
}
