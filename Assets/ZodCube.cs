using UnityEngine;
using System.Collections;

public class ZodCube : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		transform.Rotate(20*Time.deltaTime,0,0);
		
			
			if(EnemyController.timer > 200 && gameObject.transform.position.x > -20){
	gameObject.transform.Translate(0.2f,0,0,Space.World);}
	}
}
