using UnityEngine;
using System.Collections;


public class HighScore : MonoBehaviour {
		public static int highScore = 0;
	


	// Use this for initialization
	void Start () {
				

		renderer.material.color = Color.blue;
		
	
	}
	
	// Update is called once per frame
	void Update () {
		
	        GetComponent<TextMesh>().text =  highScore.ToString();
		
		renderer.material.color = Color.red;
	       
		//renderer.material.color = Color.green;
		//renderer.material.color = Color.blue;
	       
		
	
	}
}
