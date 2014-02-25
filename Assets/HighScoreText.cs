using UnityEngine;
using System.Collections;

public class HighScoreText : MonoBehaviour {
public static string condition;


	// Use this for initialization
	void Start () {
				

		renderer.material.color = Color.blue;
		condition = "High Score";
		
	
	}
	
	// Update is called once per frame
	void Update () {
		
	        GetComponent<TextMesh>().text =  condition;
		
		renderer.material.color = Color.red;
		

	       
		//renderer.material.color = Color.green;
		//renderer.material.color = Color.blue;
	       
		
	
	}
}
