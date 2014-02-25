using UnityEngine;
using System.Collections;

public class AsteroidTitle : MonoBehaviour {
			public AudioClip ouchSound;
	bool once = false;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		

					gameObject.transform.Translate(0.02f,0f,0f,Space.World);
			if(transform.position.x >9&& once ==  false){audio.PlayOneShot(ouchSound);
		once = true;}

	
	}
}
