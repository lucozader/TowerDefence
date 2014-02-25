using UnityEngine;
using System.Collections;

public class TowerRotate : MonoBehaviour {
	bool once = false;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if(once == false){
		transform.Rotate(0, 180, 0);
		once = true;}

	
	}
}
