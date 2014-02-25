using UnityEngine;
using System.Collections;

public class WomanMove : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if(EnemyController.timer > 12){
			gameObject.transform.Translate(-20f,0,0);}
	}

}
