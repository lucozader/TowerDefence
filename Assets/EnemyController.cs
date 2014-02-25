using UnityEngine;
using System.Collections;

public class EnemyController : MonoBehaviour {
	public GameObject spawn1;///template		
	//public GameObject spawn2;///template	
	//	public GameObject spawn3;///template	
	//	public GameObject spawn4;///template	
	//	public GameObject spawn5;///template	
	//public GameObject spawn6;///template	
	//	public GameObject spawn7;///template	
	//	public GameObject spawn8;///template	
		//public AudioClip etSound;
		//public AudioClip saturnSound;
		public AudioClip upgradeSound;
		//	public AudioClip sirenSound;


	public bool once = false;
	public bool once2 = false;
		public bool once3 = false;
	public static float timer = 0;




	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		timer = timer+1*Time.deltaTime;
		//Debug.Log(timer);
		if(once == false && timer >10){
			Debug.Log("now");
	transform.position = new Vector3(-440, 30, 1483);
	GameObject pro1  = Instantiate (spawn1,transform.position,Quaternion.identity) as GameObject;///specific one
	//transform.position = new Vector3(-24, 8, -8);
	//GameObject pro2  = Instantiate (spawn2,transform.position,Quaternion.identity) as GameObject;///specific one
			once = true;
	}
		/**	if(once2 == false && timer > 2800){
					
	
	transform.position = new Vector3(-6, 8, 20);
	GameObject pro4  = Instantiate (spawn3,transform.position,Quaternion.identity) as GameObject;///specific one
	transform.position = new Vector3(-25, 8, 0);
	GameObject pro5  = Instantiate (spawn4,transform.position,Quaternion.identity) as GameObject;///specific one
			once2 = true;
	transform.position = new Vector3(-6, 8, -20);
	GameObject pro6  = Instantiate (spawn5,transform.position,Quaternion.identity) as GameObject;///specific one
			once2 = true;
	}
	**/
		
					/**if(once3 == false && timer > 5600){
					
	
	transform.position = new Vector3(-6, 8, 20);
	GameObject pro4  = Instantiate (spawn3,transform.position,Quaternion.identity) as GameObject;///specific one
	transform.position = new Vector3(-25, 8, 0);
	GameObject pro5  = Instantiate (spawn4,transform.position,Quaternion.identity) as GameObject;///specific one
			once2 = true;
	transform.position = new Vector3(-6, 8, -20);
	GameObject pro6  = Instantiate (spawn5,transform.position,Quaternion.identity) as GameObject;///specific one
			once3 = true;
	}
**/
		
		
		if( timer == 900)
		{
			//GUIControllerFireEmblem.textbox = "Fecking UFO, Get out of the way!!!";
			//	audio.PlayOneShot(etSound);
		}
			if( timer == 2300)
		{
			//GUIControllerFireEmblem.textbox = "I like Majora's Mask, What a game!";
		
	}
			if( timer == 1500)
		{
			//GUIControllerFireEmblem.textbox = "Saturn 5 Rocket, Where is it going?";
			//	audio.PlayOneShot(saturnSound);
		}
			if( timer == 2600)
		{
			GUIControllerFireEmblem.textbox = "Upgrades Received";
				GUIControllerFireEmblem.upgrades= GUIControllerFireEmblem.upgrades+5;
				audio.PlayOneShot(upgradeSound);
		}
			if( timer == 2700)
		{
			//GUIControllerFireEmblem.textbox = "Second Wave Incoming";
				//audio.PlayOneShot(sirenSound);
		}
				if( timer == 3000)
		{
			//GUIControllerFireEmblem.textbox = "Damn Space Dragons!";
			
		}
			if( timer == 2500)
		{
			//GUIControllerFireEmblem.textbox = "Attack Wave 1 Survived";
		}
			if( timer == 4500)
		{
			//GUIControllerFireEmblem.textbox = "Here comes the cavalry!";
		}
			if( timer == 5200)
		{
			//GUIControllerFireEmblem.textbox = "Woot, New Firing Platforms!";
		}
		
		
			if( timer == 5300)
		{
			//GUIControllerFireEmblem.textbox = "Attack Wave 2 Survived";
		}
		
		
				if( timer == 5400)
		{
			//GUIControllerFireEmblem.textbox = "Upgrades Received";
			//	GUIControllerFireEmblem.upgrades= GUIControllerFireEmblem.upgrades+5;
				//audio.PlayOneShot(upgradeSound);
		}
		
			if( timer == 5500)
		{
			//GUIControllerFireEmblem.textbox = "Third and FINAL Wave Incoming";
			//	audio.PlayOneShot(sirenSound);
		}
	}
}
