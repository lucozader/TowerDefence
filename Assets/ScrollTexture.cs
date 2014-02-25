using UnityEngine;
using System.Collections;

public class ScrollTexture : MonoBehaviour {
	
	public float xScrollRate = 1.0f;
	public float yScrollRate = 1.0f;

	// Use this for initialization
	void Start ()
	{
		renderer.material.mainTextureOffset = Vector2.zero;
	}
	
	// Update is called once per frame
	void Update ()
	{
		Vector2 newOffset = renderer.material.mainTextureOffset;
		newOffset.x += xScrollRate * Time.deltaTime;
		newOffset.y += yScrollRate * Time.deltaTime;
		renderer.material.mainTextureOffset = newOffset;
			//if(EnemyController.pathKiller == true){
			
			//Destroy(gameObject);
			
		//}
		if(EnemyController.timer == 2500){Destroy (gameObject);}
				if(EnemyController.timer == 4500){Destroy (gameObject);}

	}
}
