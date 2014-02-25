using UnityEngine;
using System.Collections;

public class StraightenShip : MonoBehaviour {
	public GameObject bullet1;///template
	bool once = false;
	bool once1 = false;

	// Use this for initialization
	void Start () {
	
	
	}
	
	// Update is called once per frame

		void Update () {

			if(once == false){
				transform.Rotate(0, 90, 0);
				once = true;}
		if(transform.position.x > 3500&&once1 == false){
		
			GameObject test  = Instantiate (bullet1,transform.position,Quaternion.identity) as GameObject;///specific one
			once1 = true;
		}
	}

	

}