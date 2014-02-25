using UnityEngine;
using System.Collections;

public class Vader : MonoBehaviour {
		public AudioClip vaderSound;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	 void OnMouseEnter()
	{Debug.Log ("hit");
		audio.PlayOneShot(vaderSound);
	}
}
