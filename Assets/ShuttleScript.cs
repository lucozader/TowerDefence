using UnityEngine;
using System.Collections;

public class ShuttleScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		
			
			if(EnemyController.timer > 4500 && gameObject.transform.position.x > -20){
	gameObject.transform.Translate(-0.1f,0,0,Space.World);}
		if(EnemyController.timer > 4500 && gameObject.transform.position.x <= -20 && gameObject.transform.position.y > 0){
	gameObject.transform.Translate(0,-0.1f,0,Space.World);}
	
	}
}
