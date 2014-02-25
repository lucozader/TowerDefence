using UnityEngine;
using System.Collections;

public class womantext : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if(EnemyController.timer > 12){
			gameObject.transform.Translate(20f,0,0);}
	}
}
