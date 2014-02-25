using UnityEngine;
using System.Collections;

public class AnimateDragon : MonoBehaviour {

	// Use this for initialization
	void Start () {
		//gameObject.animation.CrossFade("Take_off");
				     animation["Take_off"].wrapMode = WrapMode.Loop;

	}
	
	// Update is called once per frame
	void Update () {
					//gameObject.animation.wrapMode = WrapMode.Loop;

			//gameObject.animation.CrossFade("Take_off");

	
	}
}
