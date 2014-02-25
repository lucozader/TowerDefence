using UnityEngine;
using System.Collections;

public class Saturn5game : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if(EnemyController.timer > 1500){
	gameObject.transform.Translate(0,0,0.2f);}
	}
	
}
