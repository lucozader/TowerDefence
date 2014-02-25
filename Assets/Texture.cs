using UnityEngine;
using System.Collections;

public class Texture : MonoBehaviour {
	public Texture2D test;
	public Texture2D test1;
	public int timer  = 0;
			public AudioClip explodeSound;
	public bool playOnce = false;
	public GameObject t;
		public GameObject t1;



	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		timer = timer +1;
		//Debug.Log(timer);
	renderer.material.mainTexture = test;
		if(timer > 182){
	renderer.material.mainTexture = test1;
								if(playOnce == false){audio.PlayOneShot(explodeSound);




			playOnce = true;}
}


	}
}
