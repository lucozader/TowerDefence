using UnityEngine;
using System.Collections;

public class TieFighter : MonoBehaviour {
		public AudioClip tieSound;

	// Use this for initialization
	void Start () {
	audio.PlayOneShot(tieSound);
	}
	
	// Update is called once per frame
	void Update () {
			gameObject.transform.Translate(-0.05f,0f,0f,Space.World);
		
			
	
	}
}
