using UnityEngine;
using System.Collections;

public class move : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if(EnemyController.timer > 10){
			gameObject.transform.Translate(-20f,0,0);}
	
	}
}
