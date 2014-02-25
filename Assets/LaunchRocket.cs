using UnityEngine;
using System.Collections;

public class LaunchRocket : MonoBehaviour {
	
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		gameObject.transform.Translate(0f,.02f,0f,Space.World);
	
	}
}
