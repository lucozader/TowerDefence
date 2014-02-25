using UnityEngine;
using System.Collections;

public class MoonRotate : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () 
	{
		transform.Rotate(0,40*Time.deltaTime,0);
	
	}
}
