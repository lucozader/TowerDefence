using UnityEngine;
using System.Collections;

public class Straighten : MonoBehaviour {
	bool once = false;

	// Use this for initialization
	void Start () {
	//transform.Rotate(-90, 0, 0);
	}
	
	// Update is called once per frame
	void Update () {
		if(once == false){
		transform.Rotate(-90, 0, 0);
		once = true;}

	}
}
