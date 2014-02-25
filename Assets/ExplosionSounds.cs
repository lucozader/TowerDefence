using UnityEngine;
using System.Collections;

public class ExplosionSounds : MonoBehaviour {
	public static bool playNoise1;
	public AudioClip noise1;

	// Use this for initialization
	void Start () {
		playNoise1 = false;

	}
	
	// Update is called once per frame
	void Update () {
		if(playNoise1==true){
			audio.PlayOneShot(noise1);
			playNoise1 = false;
		}
	
	}
}
