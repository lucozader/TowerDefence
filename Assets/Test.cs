using UnityEngine;
using System.Collections;

public class Test : MonoBehaviour {

		public int timer  = 0;
	public bool playOnce = false;
	public GameObject t;
		public GameObject t1;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
				timer = timer +1;

			if(timer > 182){

						
						transform.position = new Vector3(-180.7142f, 14.12154f, -3.58709f);

					GameObject proz  = Instantiate (t,transform.position,Quaternion.identity) as GameObject;///specific one
										transform.position = new Vector3(-153.718f, 72.32549f, -3.58709f);

					GameObject prozz  = Instantiate (t1,transform.position,Quaternion.identity) as GameObject;///specific one


			playOnce = true;}
}

	
	}

