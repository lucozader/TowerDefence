using UnityEngine;
using System.Collections;

public class MusicScene : MonoBehaviour {
		public AudioClip musicSound;
	bool once = false;
	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		if(EnemyController.timer>13&&once == false){
			audio.PlayOneShot(musicSound);

			once = true;
		}
	
	}
}
